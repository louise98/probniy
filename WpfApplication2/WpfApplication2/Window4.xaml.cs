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
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool levelSelected = true;
            if ((bool)veryActiveRadioButton.IsChecked)
            {
                Data.newUserActivity = "veryActive";
            }
            else if ((bool)activeRadioButton.IsChecked)
            {
                Data.newUserActivity = "active";
            }
            else if ((bool)lightlyActiveRadioButton.IsChecked)
            {
                Data.newUserActivity = "lightlyActive";
            }
            else if ((bool)notVeryActiveRadioButton.IsChecked)
            {
                Data.newUserActivity = "notVeryActive";
            }
            else
            {
                levelSelected = false;
            }
            if (levelSelected)
            {
                Window5 w = new Window5();
                w.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Choose one!");
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window3();
            win.Show();
            this.Close();
        }
    }
}
