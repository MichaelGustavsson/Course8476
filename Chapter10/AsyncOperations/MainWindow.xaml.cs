using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncOperations
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

        private void StartAsync_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                string time = DateTime.Now.ToLongTimeString();
                #region Bad Way
                //UpdateResult(time);
                #endregion

                #region Correct Way
                lblResult.Dispatcher.BeginInvoke(
                    new Action(() => UpdateResult(time)));
                #endregion
            });
        }

        private void UpdateResult(string time) {
            lblResult.Content = time;
        }

        private void AsyncWrong_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "I am waiting...";

            Task<string> task = Task.Run<string>(() => {
                Thread.Sleep(10000);
                return string.Format("I am finally done {0}",
                    DateTime.Now.ToLongTimeString());
            });

            lblResult.Content = task.Result;
         
        }

        private async void AsyncRight_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "I am waiting...";            

            Task<string> task = Task.Run<string>(() =>
            {                
                Thread.Sleep(10000);
                return string.Format("I am finally done {0}",
                    DateTime.Now.ToLongTimeString());
            });

            lblResult.Content = await task;
        }

        private async Task<string> DoLongRunningStuff()
        {           
            var result = await Task.Run<string>(() => {
                Thread.Sleep(10000);
                return string.Format("Im done {0}",
                    DateTime.Now.ToLongTimeString());
            });
            return result;            
        }

        private async void CallingLongRunningMethod_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = await DoLongRunningStuff();
        }

        private async void CallbackCall_Click(object sender, RoutedEventArgs e)
        {
            await ListData(RemoveDuplicates);
        }

        private async Task ListData(Action<IEnumerable<string>> callback)
        {
            var data = await Task.Run(() => { 
                var list = new List<string>();

                list.Add("Data 1");
                list.Add("Data 2");
                list.Add("Data 1");
                list.Add("Data 3");
                list.Add("Data 3");
                list.Add("Data 4");
                list.Add("Data 5");
                list.Add("Data 6");
                list.Add("Data 5");
                list.Add("Data 7");

                return list;
            });

            await Task.Run(() => callback(data));
        }

        private void RemoveDuplicates(IEnumerable<string> data)
        {
            IEnumerable<string> uniqueData = data.Distinct();

            Dispatcher.BeginInvoke(new Action(() => {
                lstData.ItemsSource = uniqueData;
                lblResult.Content = string.Format("Done with work!");
            }));
        }
    }
}
