using SportShop.Classes;
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
    /// Логика взаимодействия для DeliveryCompositionEdit.xaml
    /// </summary>
    public partial class DeliveryCompositionEdit : Page
    {
        private DeliveryComposition currentComposition = new DeliveryComposition();
        public DeliveryCompositionEdit(DeliveryComposition selectedComposition, Delivery selectedDelivery)
        {
            InitializeComponent();

            if (selectedComposition != null)
            {
                currentComposition = selectedComposition;
            }

            DataContext = currentComposition;

            cmbDelivery.ItemsSource = DeliveryView.contextDB.Delivery.ToList();
            if (selectedDelivery != null)
            {
                cmbDelivery.SelectedItem = selectedDelivery;
                txbText.Text = selectedDelivery.ID.ToString();
            }

            cmbProduct.ItemsSource = DeliveryView.contextDB.Product.ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
