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
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window3 w = new Window3();
            w.Show();
        }


        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            textBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
            textBox.Text = "";
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "") {
                textBox.Text = "ex.: Michael";
                var bc = new BrushConverter();
                textBox.Foreground = (Brush)bc.ConvertFrom("#FF808080");
            }
        }
    }
}
