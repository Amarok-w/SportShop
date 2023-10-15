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
    /// Логика взаимодействия для ExitModal.xaml
    /// </summary>
    public partial class ExitModal : Window
    {
        public ExitModal()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Classes.FrameApp.frame.Navigate(new Pages.Auth());
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
