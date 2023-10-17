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
using System.Windows.Shapes;

namespace SportShop.ModalWindows
{
    /// <summary>
    /// Логика взаимодействия для ErrorFillSaveModal.xaml
    /// </summary>
    public partial class ErrorFillSaveModal : Window
    {
        public ErrorFillSaveModal(StringBuilder errors)
        {
            InitializeComponent();

            string[] words = errors.ToString().Split('\n');

            foreach (string word in words)
            {
                if (word.Length != 0)
                txtErrors.Text += $"- {word} \n";
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
