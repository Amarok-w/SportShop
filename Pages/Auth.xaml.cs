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

namespace SportShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public static SportShopEntities contextDB;
        public static int SellerID;
        public Auth()
        {
            InitializeComponent();

            contextDB = new SportShopEntities();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            string login = txbLogin.Text;
            string password = psbPassword.Password;

            if (contextDB.Admin.FirstOrDefault(item => item.Login == login && item.Password == password) != null)
            {
                NavigationService.Navigate(new AdminPages.MenuAdmin());
            }
            else if (contextDB.Seller.FirstOrDefault(item => item.Login == login && item.Password == password) != null)
            {
                NavigationService.Navigate(new SellerPages.MenuSeller());
                SellerID = contextDB.Seller.FirstOrDefault(item => item.Login == login && item.Password == password).ID;
            }
            else
            {
                ErrorAuth errorAuth = new ErrorAuth();
                errorAuth.ShowDialog();
            }
            

            SellerPages.ProductList.FirstTime = true;
        }
    }
}
