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
    /// Логика взаимодействия для DeleteModal.xaml
    /// </summary>
    public partial class DeleteModal : Window
    {
        public DeleteModal(int delitingCount)
        {
            InitializeComponent();
            txtAmount.Text = delitingCount.ToString();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
