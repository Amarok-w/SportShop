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
    /// Логика взаимодействия для ProductView.xaml
    /// </summary>
    public partial class ProductView : Page
    {
        public static SportShopEntities contextDB;
        public ProductView()
        {
            InitializeComponent();
            contextDB = new SportShopEntities();

            gridProducts.ItemsSource = contextDB.Product.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new ProductEdit(null));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var delitingItems = gridProducts.SelectedItems.Cast<Product>().ToList();

            DeleteModal modal = new DeleteModal(delitingItems.Count());
            modal.ShowDialog();

            if (modal.DialogResult == true)
            {
                try
                {
                    contextDB.Product.RemoveRange(delitingItems);
                    contextDB.SaveChanges();

                    SuccessDeleteModal successModal = new SuccessDeleteModal();
                    successModal.ShowDialog();

                    FrameApp.AdminFrame.Navigate(new AdminPages.ProductView());
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
            FrameApp.AdminFrame.Navigate(new ProductEdit((sender as Button).DataContext as Product));
        }
    }
}
