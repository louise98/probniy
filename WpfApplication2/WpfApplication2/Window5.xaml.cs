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
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool genderPicked = true;
            bool birthdayPicked = true;
            if ((bool)maleRadioButton.IsChecked)
            {
                Data.newUserGender = "male";
            }
            else if ((bool)femaleRadioButton1.IsChecked)
            {
                Data.newUserGender = "female";
            }
            else
            {
                genderPicked = false;
            }
            if (birthDatePicker.SelectedDate != null)
            {
                Data.newUserBirthday = (DateTime)birthDatePicker.SelectedDate;
            }
            else
            {
                birthdayPicked = false;
            }

            if (genderPicked && birthdayPicked)
            {
                Window6 w = new Window6();
                w.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose!");
            }
            

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window4();
            win.Show();
            this.Close();
        }
    }
}
