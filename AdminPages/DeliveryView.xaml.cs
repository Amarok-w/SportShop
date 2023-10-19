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
    /// Логика взаимодействия для DeliveryView.xaml
    /// </summary>
    public partial class DeliveryView : Page
    {
        public static SportShopEntities contextDB;
        public Delivery selectedDeliveryForBox;
        public DeliveryView()
        {
            InitializeComponent();
            contextDB = new SportShopEntities();

            gridDeliveries.ItemsSource = contextDB.Delivery.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryEdit(null));
        }

        private void btnAddComposition_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryCompositionEdit(null, selectedDeliveryForBox));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (gridDeliveries.SelectedItems.Count > 0)
            {
                var delitingItems = gridDeliveries.SelectedItems.Cast<Delivery>().ToList();

                DeleteModal modal = new DeleteModal(delitingItems.Count());
                modal.ShowDialog();

                if (modal.DialogResult == true)
                {
                    try
                    {
                        contextDB.Delivery.RemoveRange(delitingItems);
                        contextDB.SaveChanges();

                        SuccessDeleteModal successModal = new SuccessDeleteModal();
                        successModal.ShowDialog();

                        FrameApp.AdminFrame.Navigate(new AdminPages.DeliveryView());
                    }
                    catch
                    {
                        ErrorDeleteModal errorDeleteModal = new ErrorDeleteModal();
                        errorDeleteModal.ShowDialog();
                    }
                }
            }
            else
            {
                var delitingItems = gridComposition.SelectedItems.Cast<DeliveryComposition>().ToList();

                DeleteModal modal = new DeleteModal(delitingItems.Count());
                modal.ShowDialog();

                if (modal.DialogResult == true)
                {
                    try
                    {
                        contextDB.DeliveryComposition.RemoveRange(delitingItems);
                        contextDB.SaveChanges();

                        SuccessDeleteModal successModal = new SuccessDeleteModal();
                        successModal.ShowDialog();

                        FrameApp.AdminFrame.Navigate(new AdminPages.DeliveryView());
                    }
                    catch
                    {
                        ErrorDeleteModal errorDeleteModal = new ErrorDeleteModal();
                        errorDeleteModal.ShowDialog();
                    }
                }
            }
        }

        private void btnEditDelivery_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryEdit((sender as Button).DataContext as Delivery));
        }

        private void btnEditComposition_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryCompositionEdit(((sender as Button).DataContext as DeliveryComposition), selectedDeliveryForBox));
        }

        private void gridDeliveries_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var selectedDelivery = gridDeliveries.SelectedItem as Delivery;
            

            if (selectedDelivery != null)
            {
                gridComposition.ItemsSource = contextDB.DeliveryComposition.Where(item => item.ID_Delivery == selectedDelivery.ID).ToList();
                selectedDeliveryForBox = selectedDelivery;
            }
        }
    }
}
