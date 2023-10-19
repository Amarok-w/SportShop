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
    /// Логика взаимодействия для SellerEdit.xaml
    /// </summary>
    public partial class SellerEdit : Page
    {
        private Seller currentSeller = new Seller();
        public SellerEdit(Seller selectedSeller)
        {
            InitializeComponent();

            if (selectedSeller != null)
            {
                currentSeller = selectedSeller;
            }

            DataContext = currentSeller;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new SellerView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(currentSeller.FirstName))
            {
                errors.Append("Фамилия \n");
            }
            if (string.IsNullOrEmpty(currentSeller.LastName))
            {
                errors.Append("Имя \n");
            }
            if (string.IsNullOrEmpty(currentSeller.Login))
            {
                errors.Append("Логин \n");
            }
            if (string.IsNullOrEmpty(currentSeller.Password))
            {
                errors.Append("Пароль \n");
            }


            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentSeller.ID == 0)
            {
                ProductView.contextDB.Seller.Add(currentSeller);
            }

            try
            {
                SellerView.contextDB.SaveChanges();
                NavigationService.Navigate(new SellerView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }
    }
}
