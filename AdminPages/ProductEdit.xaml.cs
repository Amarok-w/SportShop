using SportShop.Classes;
using SportShop.ModalWindows;
using System;
using System.Collections.Generic;
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

namespace SportShop.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для ProductEdit.xaml
    /// </summary>
    public partial class ProductEdit : Page
    {
        private Product currentProduct = new Product();
        public ProductEdit(Product selectedProduct)
        {
            InitializeComponent();

            if (selectedProduct != null )
            {
                currentProduct = selectedProduct;
            }

            DataContext = currentProduct;
            cmbCategory.ItemsSource = AdminPages.ProductView.contextDB.Category.ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new ProductView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(currentProduct.Name))
            {
                errors.Append("Наименование \n");
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                errors.Append("Категория \n");
            }
            if (string.IsNullOrEmpty(currentProduct.Photo))
            {
                errors.Append("Фото \n");
            }
            if (Convert.ToInt32(currentProduct.Price) == 0)
            {
                errors.Append("Цена \n");
            }
            if (string.IsNullOrEmpty(currentProduct.Amount.ToString()))
            {
                errors.Append("Кол-во \n");
            }


            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentProduct.ID == 0)
            {
                ProductView.contextDB.Product.Add(currentProduct);
            }

            try
            {
                ProductView.contextDB.SaveChanges();
                NavigationService.Navigate(new ProductView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }
    }
}
