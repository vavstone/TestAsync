using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAsyncWinForm
{
    public partial class Form1 : Form
    {
        static string url = "https://github.com/";
        public Form1()
        {
            InitializeComponent();
        }

        static async Task<string> GetHttpDataTaskBasedPattern()
        {
            var client = new WebClient();
            var resultTaskString = await client.DownloadStringTaskAsync(url);
            await Task.Run(() => DoSomethingHeavy());
            return resultTaskString;
        }

        static string GetHttpDataSync()
        {
            var client = new WebClient();
            var resultSync = client.DownloadString(url);
            DoSomethingHeavy();
            return resultSync;
        }

        static void DoSomethingHeavy()
        {
            double x = 2;
            for (int i = 1; i < 500000000; i++)
                x += Math.Sqrt(x) / i;
        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = GetHttpDataSync();
        }

        private async void btGetHttpDataAsync_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = await GetHttpDataTaskBasedPattern();
        }
    }
}
