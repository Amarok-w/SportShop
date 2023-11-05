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

namespace SportShop.SellerPages
{
    /// <summary>
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Page
    {
        public static SportShopEntities contextDB = new SportShopEntities();
        public static List<Product> products;
            // = contextDB.Product.ToList();
        public static Boolean FirstTime = true;

        public static List<Product> productsInCart = new List<Product>();

        public ProductList()
        {
            InitializeComponent();

            if (FirstTime)
            {
                FirstTime = false;
                products = contextDB.Product.ToList();

                foreach (var item in products)
                {
                    item.NotInCart = true;
                }
            }

            ListViewProducts.ItemsSource = products;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var PressedButton = (sender as Button).DataContext as Product;

            if (PressedButton.Amount == 0)
            {
                ErrorAmount errorAmount = new ErrorAmount();
                errorAmount.ShowDialog();
                return;
            }

            (products.FirstOrDefault(item => item.ID == PressedButton.ID)).NotInCart = false;
            ListViewProducts.ItemsSource = null;
            ListViewProducts.ItemsSource = products;

            // Добавление в корзину
            productsInCart.Add(PressedButton);

        }
    }
}
