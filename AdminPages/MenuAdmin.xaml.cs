﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SportShop.Classes;
using SportShop.ModalWindows;

namespace SportShop.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Page
    {
        public MenuAdmin()
        {
            InitializeComponent();
            FrameApp.AdminFrame = frmAdmin;

            frmAdmin.Navigate(new EmptyPageAdmin());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitModal modal = new ExitModal();
            modal.ShowDialog();
        }

        private void btnCategories_Click(object sender, RoutedEventArgs e)
        {
            btnToggle.IsChecked = btnToggle.IsChecked == true ? false : btnToggle.IsChecked;
            frmAdmin.Navigate(new CategoryView());
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            btnToggle.IsChecked = btnToggle.IsChecked == true ? false : btnToggle.IsChecked;
            frmAdmin.Navigate(new ProductView());
        }

        private void btnProviders_Click(object sender, RoutedEventArgs e)
        {
            btnToggle.IsChecked = btnToggle.IsChecked == true ? false : btnToggle.IsChecked;
            frmAdmin.Navigate(new ProviderView());
        }

        private void btnDelivery_Click(object sender, RoutedEventArgs e)
        {
            btnToggle.IsChecked = btnToggle.IsChecked == true ? false : btnToggle.IsChecked;
            frmAdmin.Navigate(new DeliveryView());
        }

        private void btnSellers_Click(object sender, RoutedEventArgs e)
        {
            btnToggle.IsChecked = btnToggle.IsChecked == true ? false : btnToggle.IsChecked;
            frmAdmin.Navigate(new SellerView());
        }
    }
}
