using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Timers;
//using System.Diagnostics;

namespace HelloXaml
{
    public partial class MainPage : ContentPage
    {
            bool isRunning = false;

        public MainPage()
        {
            InitializeComponent();

            lblTimer.Text = DateTime.Now.ToString("T");
            Device.StartTimer(TimeSpan.FromSeconds(1), HandleFunc);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            isRunning = !isRunning;
            btnTimer.Text = isRunning ? "Stop" : "Start";
        }

        bool HandleFunc()
        {
            if(isRunning) {
                lblTimer.Text = DateTime.Now.ToString("T");
            }
            return true;
        }

    }
}
