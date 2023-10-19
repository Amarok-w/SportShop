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
    /// Логика взаимодействия для DeliveryEdit.xaml
    /// </summary>
    public partial class DeliveryEdit : Page
    {
        private Delivery currentDelivery = new Delivery();
        public DeliveryEdit(Delivery selectedDelivery)
        {
            InitializeComponent();

            if (selectedDelivery != null)
            {
                currentDelivery = selectedDelivery;
            }

            DataContext = currentDelivery;

            cmbProvider.ItemsSource = DeliveryView.contextDB.Provider.ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (cmbProvider.SelectedIndex == -1)
            {
                errors.Append("Поставщик \n");
            }
            if (string.IsNullOrEmpty(txbDeliveryDate.Text))
            {
                errors.Append("Дата поставки \n");
            }

            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentDelivery.ID == 0)
            {
                DeliveryView.contextDB.Delivery.Add(currentDelivery);
            }

            try
            {
                DeliveryView.contextDB.SaveChanges();
                NavigationService.Navigate(new DeliveryView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }
    }
}
