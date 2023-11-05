﻿using SportShop.Classes;
using SportShop.ModalWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            cmbProduct.ItemsSource = DeliveryView.contextDB.Product.ToList();
            cmbDelivery.ItemsSource = DeliveryView.contextDB.Delivery.ToList();

            DataContext = currentComposition;

            if (selectedDelivery != null)
            {
                currentComposition.ID_Delivery = selectedDelivery.ID;
                cmbDelivery.UpdateLayout();
                cmbDelivery.SelectedItem = selectedDelivery;
            }

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.AdminFrame.Navigate(new DeliveryView());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (cmbDelivery.SelectedIndex == -1)
            {
                errors.Append("Номер поставки \n");
            }
            if (cmbProduct.SelectedIndex == -1)
            {
                errors.Append("Товар \n");
            }
            if (string.IsNullOrEmpty(txbAmount.Text.ToString()))
            {
                errors.Append("Кол-во \n");
            }

            if (errors.Length > 0)
            {
                ErrorFillSaveModal errorFillModal = new ErrorFillSaveModal(errors);
                errorFillModal.ShowDialog();

                return;
            }

            if (currentComposition.ID == 0)
            {
                DeliveryView.contextDB.DeliveryComposition.Add(currentComposition);
            }

            try
            {
                DeliveryView.contextDB.SaveChanges();
                NavigationService.Navigate(new DeliveryView());
            }
            catch
            {
                ErrorSaveModal errorSaveModal = new ErrorSaveModal();
                errorSaveModal.ShowDialog();
            }
        }

    }
}
