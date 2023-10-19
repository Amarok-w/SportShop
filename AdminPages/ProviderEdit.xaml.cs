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
    /// Логика взаимодействия для ProviderEdit.xaml
    /// </summary>
    public partial class ProviderEdit : Page
    {
        private Provider currentProvider = new Provider();
        public ProviderEdit(Provider selectedProvider)
        {
            InitializeComponent();

            if (selectedProvider != null )
            {
                currentProvider = selectedProvider;
            }

            DataContext = currentProvider;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new ProviderView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(currentProvider.Name))
            {
                errors.Append("Наименование \n");
            }

            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentProvider.ID == 0)
            {
                ProviderView.contextDB.Provider.Add(currentProvider);
            }

            try
            {
                ProviderView.contextDB.SaveChanges();
                NavigationService.Navigate(new ProviderView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }
    }
}
