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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window8 w = new Window8();
            w.Show();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Window9 w = new Window9();
            w.Show();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Window10 w = new Window10();
            w.Show();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window11 w = new Window11();
            w.Show();
        }
    }
}
