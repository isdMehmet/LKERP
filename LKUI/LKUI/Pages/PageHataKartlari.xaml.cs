﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LKUI.Pages
{
    /// <summary>
    /// Interaction logic for PageHataKartlari.xaml
    /// </summary>
    public partial class PageHataKartlari : UserControl
    {
        public PageHataKartlari()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            ChildHataKartlariEkle.Show();

        }

       
    }
}
