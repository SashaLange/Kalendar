﻿using System;
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

namespace Kalendar
{
    /// <summary>
    /// Логика взаимодействия для baldej.xaml
    /// </summary>
    public partial class baldej : UserControl
    {
        public baldej()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {           
            (Application.Current.MainWindow as MainWindow).PageFrame.Content = new Page1();
        }
    }
}
