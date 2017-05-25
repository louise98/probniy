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
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool goalSet = true;
            if ((bool)loseRadioButton.IsChecked)
            {
                Data.newUserGoal = "lose";
            }
            else if ((bool)maintainRadioButton.IsChecked)
            {
                Data.newUserGoal = "maintain";
            }
            else if ((bool)gainRadioButton.IsChecked)
            {
                Data.newUserGoal = "gain";
            }
            else
            {
                MessageBox.Show("Choose a goal!");
                goalSet = false;
            }
            if (goalSet)
            {
                Window4 w = new Window4();
                w.Show();
                this.Close();
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window2();
            win.Show();
            this.Close();
        }
    }
}
