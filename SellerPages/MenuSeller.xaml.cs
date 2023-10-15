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
using SportShop.ModalWindows;
using SportShop.Classes;

namespace SportShop.SellerPages
{
    /// <summary>
    /// Логика взаимодействия для MenuSeller.xaml
    /// </summary>
    public partial class MenuSeller : Page
    {
        public MenuSeller()
        {
            InitializeComponent();
            Classes.FrameApp.sellerFrame = frmSeller;
            FrameApp.sellerFrame.Navigate(new EmptyPageSeller());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitModal modal = new ExitModal();
            modal.ShowDialog();

        }
    }
}
