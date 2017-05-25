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
            String name = nameTextBox.Text;
            String password = passwordBox.Password;
            String repeatPassword = repeatPasswordBox.Password;
            if(HelperFunctions.validateUsername(name) && 
                HelperFunctions.validatePassword(password) &&
                password == repeatPassword)
            {
                Data.newUserName = name;
                Data.newUserPassword = password;
                Window3 w = new Window3();
                w.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid data!");
            }
            
        }


        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            nameTextBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
            nameTextBox.Text = "";
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            win.Show();
            this.Close();
        }
    }
}
