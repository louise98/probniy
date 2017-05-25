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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HelperFunctions.deserUsers();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
           this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String name = nameTextBox.Text;
            String password = passwordBox.Password;
            foreach(User user in Data.users)
            {
                if (user.Name == name && user.shouldLogin(password))
                {
                    Data.currentUser = user;
                    Window7 w = new Window7();
                    w.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("No such user with such password!");
        }
    }
}
