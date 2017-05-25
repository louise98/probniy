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
using System.Web;
using System.Net;
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome back, " + Data.currentUser.Name + "!";

            var url = "http://127.0.0.1:5000/pie?names=";
            foreach(var meal in Data.currentUser.history)
            {
                if(DateTime.Today.DayOfYear == meal.dateConsumed.DayOfYear && DateTime.Today.Year == meal.dateConsumed.Year)
                {
                    var mealName = "";
                    foreach(var c in meal.Name)
                    {
                        if(c == ' ')
                        { 

                            mealName += "%20";
                        }
                        else
                        {
                            mealName += c.ToString();
                        }
                    }
                    url = url += mealName+";";
                }
            }

            url += "&values=";
            foreach (var meal in Data.currentUser.history)
            {
                if (DateTime.Today.DayOfYear == meal.dateConsumed.DayOfYear && DateTime.Today.Year == meal.dateConsumed.Year)
                {
                    var mealValue = meal.Total.ToString();
                    url = url += mealValue+";";
                }
            }
            

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(url, "D:/pie.png");

                    BitmapImage image_ = new BitmapImage();
                    image_.BeginInit();
                    image_.CacheOption = BitmapCacheOption.OnLoad;
                    image_.UriSource = new Uri(@"D:/pie.png");
                    image_.EndInit();
                    image.Source = image_;
                }
                catch(Exception e) {
                    MessageBox.Show(e.ToString());
                }
            }
            double consumedToday = 0;
            foreach(var meal in Data.currentUser.history)
            {
                consumedToday += meal.Total;
            }
            progressText.Content = consumedToday.ToString() + " kkal out of " + (Data.currentUser._goal == Goal.lose ? 1400 : 2000).ToString() + " consumed today";
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window8 w = new Window8();
            w.Show();
            this.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Window9 w = new Window9();
            w.Show();
            this.Close();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Window10 w = new Window10();
            w.Show();
            this.Close();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
           Window11 w = new Window11();
            w.Show();
            this.Close();
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var win = new imageExpanded();

            BitmapImage image_ = new BitmapImage();
            image_.BeginInit();
            image_.CacheOption = BitmapCacheOption.OnLoad;
            image_.UriSource = new Uri(@"D:/pie.png");
            image_.EndInit();
            win.image.Source = image_;

            win.Show();
            
        }
    }
}
