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
 
    public partial class eat : UserControl
    {
        private Uri first_eat;

        public eat(Uri uri)
        {
            InitializeComponent();
            first_eat = uri;
            DzyubaTop.Source = new BitmapImage(uri);
        }


    }
}
