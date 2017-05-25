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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String name = nameTextBox.Text;
                int netValue = Int32.Parse(netValueTextBox.Text);

                Meal newMeal = new Meal(name, netValue);
                Data.meals.Add(newMeal);
                MessageBox.Show("New meal added!");
                HelperFunctions.serUsers();
                var win = new Window9();
                win.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter correct data!");
            }


        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window9();
            win.Show();
            this.Close();
        }

        private void nameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = "";
            var bc = new BrushConverter();
            nameTextBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }

        private void netValueTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            netValueTextBox.Text = "";
            var bc = new BrushConverter();
            netValueTextBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
