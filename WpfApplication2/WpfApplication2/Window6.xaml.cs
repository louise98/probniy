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
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int height;
            double currentWeight;
            double goalWeight;
            try
            {
                height = Int32.Parse(heightTextBox.Text);
                currentWeight = Double.Parse(currentWeightTextBox.Text);
                goalWeight = Double.Parse(goalWeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid data! Error");
                return;
            }
            if (HelperFunctions.validateHeight(height) &&
                HelperFunctions.validateWeight(currentWeight) &&
                HelperFunctions.validateWeight(goalWeight))
            {
                Data.newUserHeight = height;
                Data.newUserCurrentWeight = currentWeight;
                Data.newUserGoalWeight = goalWeight;
                HelperFunctions.signUpNewUser();

                Window7 w = new Window7();
                w.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid data! Non valid");
            }
            

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window5();
            win.Show();
            this.Close();
        }

        private void heightTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            heightTextBox.Text = "";
            var bc = new BrushConverter();
            heightTextBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }

        private void currentWeightTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            currentWeightTextBox.Text = "";
            var bc = new BrushConverter();
            currentWeightTextBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }

        private void goalWeightTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            goalWeightTextBox.Text = "";
            var bc = new BrushConverter();
            goalWeightTextBox.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
