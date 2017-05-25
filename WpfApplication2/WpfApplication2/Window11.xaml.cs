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
    ///

    public partial class Window11 : Window
    {
        public Window11()
        {
            InitializeComponent();
            comboBox.ItemsSource = new List<String> { "День", "Неделя", "Месяц", "Год", "Все время" };

            ///////

            

            /////
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window7();
            win.Show();
            this.Close();
        }

        int abs(int a)
        {
            return a >= 0 ? a : -1*a;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = comboBox.SelectedValue.ToString();
            var today = DateTime.Today;
            List<Meal> list = new List<Meal>();
            switch (value)
            {
                case "День":
                    list.Clear();
                    foreach(var meal in Data.currentUser.history)
                    {
                        if( meal.dateConsumed.Year == today.Year && 
                        meal.dateConsumed.Month == today.Month &&
                        meal.dateConsumed.Day == today.Day )
                        {
                            list.Add(meal);
                        }
                    }
                    dataGrid.ItemsSource = list;
                    break;
                case "Неделя":
                    list.Clear();
                    foreach (var meal in Data.currentUser.history)
                    {
                        if (abs(meal.dateConsumed.DayOfYear - today.DayOfYear) < 7)
                        {
                            list.Add(meal);
                        }
                    }
                    dataGrid.ItemsSource = list;
                    break;
                case "Месяц":
                    list.Clear();
                    foreach (var meal in Data.currentUser.history)
                    {
                        if (meal.dateConsumed.Year == today.Year &&
                        meal.dateConsumed.Month == today.Month)
                        {
                            list.Add(meal);
                        }
                    }
                    dataGrid.ItemsSource = list;
                    break;
                case "Год":
                    list.Clear();
                    foreach (var meal in Data.currentUser.history)
                    {
                        if (meal.dateConsumed.Year == today.Year)
                        {
                            list.Add(meal);
                        }
                    }
                    dataGrid.ItemsSource = list;
                    break;
                case "Все время":
                    dataGrid.ItemsSource = Data.currentUser.history;
                    break;
            }
            dataGrid.Columns[0].Header = "Meal name";
            dataGrid.Columns[1].Header = "Net value of 100gr, kkal";
            dataGrid.Columns[2].Header = "Eaten amount, gr";
            dataGrid.Columns[3].Header = "Date";
            dataGrid.Columns[4].Header = "Total value, kkal";
        }
    }
}
