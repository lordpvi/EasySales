﻿using EasySales.Infrastructure.UI;
using EasySales.Presentation.WPF.ViewModels;
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

namespace EasySales.Presentation.WPF.Views
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : Window, IView
    {
        public CustomerList()
        {
            InitializeComponent();
            this.DataContext = new CustomerListViewModel(this);
        }
    }
}
