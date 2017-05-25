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
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            nameTextBox.Text = Data.currentUser.Name;
            heightTextBox.Text = Data.currentUser.Height.ToString();
            birthdayDatePicker.SelectedDate = Data.currentUser.Birthday;
            if(Data.currentUser._gender == Gender.male)
            {
                maleRadioButton.IsChecked = true;
            }
            else
            {
                femaleRadioButton.IsChecked = true;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String oldUsername = Data.currentUser.Name;
            String name = nameTextBox.Text;
            if (HelperFunctions.validateUsername(name))
            {
                Data.currentUser.Name = name;
            }
            try
            {
                int height = Int32.Parse(heightTextBox.Text);
                if (HelperFunctions.validateHeight(height))
                {
                    Data.currentUser.Height = height;
                }
            } catch { }
            Gender? gender = null;
            if ((bool)maleRadioButton.IsChecked)
            {
                gender = Gender.male;
            }
            if ((bool)femaleRadioButton.IsChecked)
            {
                gender = Gender.female;
            }
            if(gender != null)
            {
                Data.currentUser._gender = (Gender)gender;
            }

            DateTime? birthday = birthdayDatePicker.SelectedDate;
            if(birthday != null)
            {
                Data.currentUser.Birthday = (DateTime)birthday;
            }

            HelperFunctions.serUsers();
            Window7 w = new Window7();
            w.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window7 w = new Window7();
            w.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window9 w = new Window9();
            w.Show();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window7();
            win.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var index = -1;
            for(int i=0; i<Data.users.Count; i++)
            {
                if(Data.users[i] == Data.currentUser)
                {
                    index = i;
                    break;
                }
            }
            if(index != -1)
            {
                Data.users.RemoveAt(index);
                HelperFunctions.serUsers();
                var win = new MainWindow();
                win.Show();
                this.Close();

            }
            
        }
    }
}
