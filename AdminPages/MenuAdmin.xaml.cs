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
using SportShop.Classes;
using SportShop.ModalWindows;

namespace SportShop.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Page
    {
        public MenuAdmin()
        {
            InitializeComponent();
            FrameApp.AdminFrame = frmAdmin;

            frmAdmin.Navigate(new EmptyPageAdmin());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitModal modal = new ExitModal();
            modal.ShowDialog();
        }

        private void btnCategories_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProviders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelivery_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSellers_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
