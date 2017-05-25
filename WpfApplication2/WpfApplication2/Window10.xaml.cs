using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();


            var url = "http://127.0.0.1:5000/flow?x=";
            List<int> x = new List<int>();
            List<double> y = new List<double>();
            Dictionary<int, double> dict = new Dictionary<int, double>();
            var currentYear = DateTime.Today.Year;
            foreach (var meal in Data.currentUser.history)
            {
                if (meal.dateConsumed.Year == currentYear)
                {
                    dict[meal.dateConsumed.DayOfYear] = dict.ContainsKey(meal.dateConsumed.DayOfYear) ? dict[meal.dateConsumed.DayOfYear] + meal.Total : meal.Total;
                }
            }

            foreach (var pair in dict)
            {
                x.Add(pair.Key);
                y.Add(pair.Value);
            }

            foreach (var a in x)
            {
                url += a.ToString() + ";";
            }
            url += "&y=";
            foreach (var a in y)
            {
                url += a.ToString() + ";";
            }

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(url, "D:/flow.png");

                    BitmapImage image_ = new BitmapImage();
                    image_.BeginInit();
                    image_.CacheOption = BitmapCacheOption.OnLoad;
                    image_.UriSource = new Uri(@"D:/flow.png");
                    image_.EndInit();
                    image.Source = image_;
                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());
                }
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window7();
            win.Show();
            this.Close();

        }
    }
}
