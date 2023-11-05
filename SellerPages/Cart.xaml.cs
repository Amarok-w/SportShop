using SportShop.Classes;
using SportShop.ModalWindows;
using SportShop.Pages;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace SportShop.SellerPages
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Page
    {
        public static Sale currentSale = new Sale();
        public static List<SaleComposition> cartSales = new List<SaleComposition>();
        public static SportShopEntities contextDB;

        public static decimal sum = 0; // Sale Sum

        public Cart()
        {
            InitializeComponent();
            contextDB = new SportShopEntities();
            DataContext = currentSale;

            // ======

            cmbClient.ItemsSource = contextDB.Client.ToList();



            // products
            foreach (var item in ProductList.productsInCart)
            {
                SaleComposition composition = new SaleComposition();

                composition.ID_Product = item.ID;
                composition.ID_Sale = currentSale.ID;
                composition.Amount = 1;

                contextDB.SaleComposition.Local.Add(composition);
                currentSale.SaleComposition.Add(composition);
            }

            ListViewCart.DataContext = contextDB.Product.ToList();
            ListViewCart.ItemsSource = contextDB.SaleComposition.Local;

            RefreshSum();
        }

        private void btnDeleteAmount_Click(object sender, RoutedEventArgs e)
        {
            if (((sender as Button).DataContext as SaleComposition).Amount > 1)
            {
                ((sender as Button).DataContext as SaleComposition).Amount--;

                ListViewCart.ItemsSource = null;
                ListViewCart.ItemsSource = contextDB.SaleComposition.Local.ToBindingList();
            }

            RefreshSum();
        }

        private void btnAddAmount_Click(object sender, RoutedEventArgs e)
        {
            var selectedComposition = (sender as Button).DataContext as SaleComposition;
            Product selectedProduct = contextDB.Product.FirstOrDefault(x => x.ID == selectedComposition.ID_Product);

            if (selectedProduct.Amount <= selectedComposition.Amount)
            {
                ErrorAmount errorAmount = new ErrorAmount();
                errorAmount.ShowDialog();
                return;
            }

            ((sender as Button).DataContext as SaleComposition).Amount += 1;

            ListViewCart.ItemsSource = null;
            ListViewCart.ItemsSource = contextDB.SaleComposition.Local.ToBindingList();

            RefreshSum();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            SaleComposition selectedComposition = (sender as Button).DataContext as SaleComposition;
            contextDB.SaleComposition.Local.Remove(selectedComposition);
            currentSale.SaleComposition.Remove(selectedComposition);
            ListViewCart.ItemsSource = null;
            ListViewCart.ItemsSource = contextDB.SaleComposition.Local;

            RefreshSum();

            var deletedProduct = ProductList.products.FirstOrDefault(item => item.ID == selectedComposition.ID_Product);
            deletedProduct.NotInCart = true;

            ProductList.productsInCart.Remove(deletedProduct);
   
        }

        public void RefreshSum()
        {
            sum = 0;
            foreach (var item in currentSale.SaleComposition)
            {
                sum += item.TotalCost;
            }

            txbSum.Text = Math.Round(sum, 1).ToString().Replace(",", ".") + " руб";
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (currentSale.ID == 0)
            {
                currentSale.ID_Seller = Auth.SellerID;
                currentSale.DateOfSale = DateTime.Now;
                contextDB.Sale.Add(currentSale);
            }

            try
            {
                contextDB.SaveChanges();
            }
            catch
            {
                ErrorSaveModal errorSave = new ErrorSaveModal();
                errorSave.ShowDialog();
                return;
            }

            try
            {
                // Печать чека
                var app = new Word.Application();
                Word.Document document = app.Documents.Add();

                Word.Paragraph p1 = document.Paragraphs.Add();
                Word.Range range1 = p1.Range;

                range1.Text = $"Чек: {currentSale.Client.LastName} {currentSale.Client.FirstName}";
                range1.Font.Bold = 5;
                range1.Font.Size = 18;
                range1.Font.Name = "Times New Romans";
                p1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                range1.InsertParagraphAfter();

                // Создание таблицы
                int size = 0;
                size = contextDB.SaleComposition.Local.Count();

                Word.Paragraph p2 = document.Paragraphs.Add();
                Word.Range range2 = p2.Range;
                Word.Table table = document.Tables.Add(range2, size + 1, 3);
                // table.Columns[2].Width = 200;
                table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                // Шапка таблицы
                Word.Range cellrange;

                cellrange = table.Cell(1, 1).Range;
                cellrange.Font.Bold = 5;
                cellrange.Font.Size = 14;
                cellrange.Text = "Название";

                cellrange = table.Cell(1, 2).Range;
                cellrange.Font.Bold = 5;
                cellrange.Font.Size = 14;
                cellrange.Text = "Кол-во";

                cellrange = table.Cell(1, 3).Range;
                cellrange.Font.Bold = 5;
                cellrange.Font.Size = 14;
                cellrange.Text = "Сумма";

                //cellrange = table.Cell(1, 4).Range;
                //cellrange.Font.Bold = 5;
                //cellrange.Font.Size = 14;
                //cellrange.Text = "Материал";

                //cellrange = table.Cell(1, 5).Range;
                //cellrange.Font.Bold = 5;
                //cellrange.Font.Size = 14;
                //cellrange.Text = "Кол-во";

                //cellrange = table.Cell(1, 6).Range;
                //cellrange.Font.Bold = 5;
                //cellrange.Font.Size = 14;
                //cellrange.Text = "Стоимость";


                // Заполнение таблицы
                int saleRow = 0;
                var prods = contextDB.SaleComposition.Local;

                foreach (var sale in prods)
                {
                    saleRow++;

                    cellrange = table.Cell(saleRow + 1, 1).Range;
                    cellrange.Font.Bold = 5;
                    cellrange.Text = sale.Product.Name.ToString();

                    cellrange = table.Cell(saleRow + 1, 2).Range;
                    cellrange.Font.Bold = 5;
                    cellrange.Text = sale.Amount.ToString();

                    cellrange = table.Cell(saleRow + 1, 3).Range;
                    cellrange.Font.Bold = 5;
                    cellrange.Text = sale.TotalCost.ToString();

                    //cellrange = table.Cell(saleRow + 1, 4).Range;
                    //cellrange.Font.Bold = 5;
                    //// cellrange.Text = sale.Product.ID.ToString();

                    //cellrange = table.Cell(saleRow + 1, 5).Range;
                    //cellrange.Font.Bold = 5;
                    //cellrange.Text = sale.Amount.ToString();

                    //cellrange = table.Cell(saleRow + 1, 6).Range;
                    //cellrange.Font.Bold = 5;
                    //cellrange.Text = sale.TotalCost.ToString();
                }
                range2.InsertParagraphAfter();

                // Итоговая сумма
                Word.Paragraph p3 = document.Paragraphs.Add();
                Word.Range range3 = p3.Range;

                range3.Text = $"Итого к оплате: {Math.Round(sum, 1).ToString().Replace(",", ".")} руб. \n Номер заказа: {currentSale.ID}";

                // Сохранение
                try
                {
                    string name = @"D:\Sell.pdf";
                    document.ExportAsFixedFormat(@name, Word.WdExportFormat.wdExportFormatPDF, true);
                    document.SaveAs2(@name, Word.WdExportFormat.wdExportFormatPDF);
                }
                catch
                {
                    ErrorSaveModal errorSave = new ErrorSaveModal();
                    errorSave.ShowDialog();
                    return;
                }

                // Update
                currentSale = new Sale();
                contextDB = new SportShopEntities();
                sum = 0;

                ProductList.FirstTime = true;
                ProductList.productsInCart.Clear();
                ProductList.contextDB = new SportShopEntities();
                ProductList.products.Clear();

                FrameApp.sellerFrame.Navigate(new ProductList());
                // ProductList.products = ProductList.contextDB.Product.ToList();
            }
            catch
            {
                ErrorSaveModal errorSave = new ErrorSaveModal();
                errorSave.ShowDialog();
                return;
            }
        }
    }
}
