using SportShop.Classes;
using SportShop.ModalWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для ClientView.xaml
    /// </summary>
    public partial class ClientView : Page
    {
        public static SportShopEntities contextDB;
        public ClientView()
        {
            InitializeComponent();
            contextDB = new SportShopEntities();

            gridClients.ItemsSource = contextDB.Client.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.sellerFrame.Navigate(new ClientEdit(null));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var delitingItems = gridClients.SelectedItems.Cast<Client>().ToList();

            DeleteModal modal = new DeleteModal(delitingItems.Count());
            modal.ShowDialog();

            if (modal.DialogResult == true)
            {
                try
                {
                    contextDB.Client.RemoveRange(delitingItems);
                    contextDB.SaveChanges();

                    SuccessDeleteModal successModal = new SuccessDeleteModal();
                    successModal.ShowDialog();

                    FrameApp.sellerFrame.Navigate(new SellerPages.ClientView());
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
            FrameApp.sellerFrame.Navigate(new ClientEdit((sender as Button).DataContext as Client));
        }
    }
}
