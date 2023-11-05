using SportShop.AdminPages;
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

namespace SportShop.SellerPages
{
    /// <summary>
    /// Логика взаимодействия для ClientEdit.xaml
    /// </summary>
    public partial class ClientEdit : Page
    {
        private Client currentClient = new Client();
        public ClientEdit(Client selectedClient)
        {
            InitializeComponent();

            if (selectedClient != null)
            {
                currentClient = selectedClient;
            }

            DataContext = currentClient;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.sellerFrame.Navigate(new ClientView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(currentClient.LastName))
            {
                errors.Append("Фамилия \n");
            }
            if (string.IsNullOrEmpty(currentClient.FirstName))
            {
                errors.Append("Имя \n");
            }
            if (string.IsNullOrEmpty(currentClient.Patronymic))
            {
                errors.Append("Отчество \n");
            }
            if (string.IsNullOrEmpty(currentClient.Phone))
            {
                errors.Append("Телефон \n");
            }
            if (string.IsNullOrEmpty(currentClient.DateOfBirth.ToString()))
            {
                errors.Append("Дата рождения \n");
            }


            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentClient.ID == 0)
            {
                ClientView.contextDB.Client.Add(currentClient);
            }

            try
            {
                ClientView.contextDB.SaveChanges();
                NavigationService.Navigate(new ClientView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }
    }
}
