using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.Json;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oimo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void Btn_Click(object sender, RoutedEventArgs e)
        {
            //Проверка Get
            //using (var client = new HttpClient())
            //{
            //    var url = new Uri("https://billing.crm.mycloud.kg/pay/main.php ");
            //    var result = client.GetAsync(url).Result;
            //    var json = result.Content.ReadAsStringAsync().Result;
            //    Lbl.Content = json;
            //}

            string token = "yVKdAGWwCu6sb7j8CNjhiW7JeFv7CBlN";
            string date = DateTime.Now.ToString();
            double amount = 100;
            string action = "pay";

            using (var client = new HttpClient())
            {
                var uri = new Uri("https://billing.crm.mycloud.kg/pay/main.php ");
                var newPost = new OutData()
                {
                    token = token,
                    account_number = txtBx.Text,
                    refill_date_time = date,
                    amount = amount,
                    action = action
                };

                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payLoad = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(uri, payLoad).Result.Content.ReadAsStringAsync().Result;
                Lbl.Content = result;
            }


         

        }

    }
}