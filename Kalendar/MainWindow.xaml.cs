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

namespace Kalendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime date;
        public MainWindow()
        {

            InitializeComponent();
            date = DateTime.Now;
            dateTxt.Text = date.ToString("MMMM yyyy");
            schet(DateTime.DaysInMonth(date.Year, date.Month));

        }

        private void button_click1(object sender, RoutedEventArgs e)
        {
            date = date.AddMonths(-1);
            dateTxt.Text = date.ToString("MMMM yyyy");
            Kalendar.Children.Clear();
            schet(DateTime.DaysInMonth(date.Year, date.Month));

        }

        private void button_click2(object sender, RoutedEventArgs e)
        {
            date = date.AddMonths(1);
            dateTxt.Text = date.ToString("MMMM yyyy");

            Kalendar.Children.Clear();
            schet(DateTime.DaysInMonth(date.Year, date.Month));
           
        }
        private void schet(int month)
        {
            List<baldej> kalendars = new List<baldej>();
            for (int i = 1; i <= month; i++)
            {
                baldej a = new baldej();
                a.KalendarName.Text = i.ToString();
                Kalendar.Children.Add(a);
            }
        }

       
    }
}