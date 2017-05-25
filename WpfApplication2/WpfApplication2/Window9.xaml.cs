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
    
        
    

    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
            foreach(Meal meal in Data.meals)
            {
                mealsCombo.Items.Add(meal.Name);
            }
            for(double i = 50; i < 500; i+=50)
            {
                amountsCombo.Items.Add(i);
            }
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window7();
            win.Show();
            this.Close();
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window7 w = new Window7();
            w.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window12 w = new Window12();
            w.Show();
            this.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            var mealName = mealsCombo.SelectedValue;
            Meal meal = null;
            foreach(var m in Data.meals)
            {
                if(m.Name == (string)mealName)
                {
                    meal = m;
                    break;
                }
            }
            int amount = 0;
            try
            {
                //MessageBox.Show(amountsCombo.SelectedValue.ToString());
                amount = int.Parse(amountsCombo.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Pick an amount!");
                return;
            }
            DateTime date;
            try
            {
                date = (DateTime)datePicker.SelectedDate;
            } catch { MessageBox.Show("Pick a date!"); return; }
           
            meal.amountConsumed = amount;
            meal.dateConsumed = date;
            
            Data.currentUser.history.Add(meal);
            HelperFunctions.serUsers();
            MessageBox.Show("Added to your history");

            var win = new Window7();
            win.Show();
            this.Close();

        }
    }
}
