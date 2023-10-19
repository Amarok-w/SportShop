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
    /// Логика взаимодействия для SellerView.xaml
    /// </summary>
    public partial class SellerView : Page
    {
        public static SportShopEntities contextDB;
        public SellerView()
        {
            InitializeComponent();
            contextDB = new SportShopEntities();

            gridSellers.ItemsSource = contextDB.Seller.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new SellerEdit(null));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var delitingItems = gridSellers.SelectedItems.Cast<Seller>().ToList();

            DeleteModal modal = new DeleteModal(delitingItems.Count());
            modal.ShowDialog();

            if (modal.DialogResult == true)
            {
                try
                {
                    contextDB.Seller.RemoveRange(delitingItems);
                    contextDB.SaveChanges();

                    SuccessDeleteModal successModal = new SuccessDeleteModal();
                    successModal.ShowDialog();

                    FrameApp.AdminFrame.Navigate(new AdminPages.SellerView());
                }
                catch
                {
                    ErrorDeleteModal errorDeleteModal = new ErrorDeleteModal();
                    errorDeleteModal.ShowDialog();
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new SellerEdit((sender as Button).DataContext as Seller));
        }
    }
}
