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
    /// Логика взаимодействия для CategoryEdit.xaml
    /// </summary>
    public partial class CategoryEdit : Page
    {
        private Category currentCategory = new Category();
        public CategoryEdit(Category selectedCategory)
        {
            InitializeComponent();

            if (selectedCategory != null)
            {
                currentCategory = selectedCategory;
            }

            DataContext = currentCategory;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new CategoryView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(currentCategory.Name))
            {
                errors.Append("Наименование \n");
            }

            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal  = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentCategory.ID == 0)
            {
                CategoryView.contextDB.Category.Add(currentCategory);
            }

            try
            {
                CategoryView.contextDB.SaveChanges();
                NavigationService.Navigate(new CategoryView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }
    }
}
