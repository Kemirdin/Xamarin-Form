using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTimer {
    public partial class TimerPage : ContentPage {
        public TimerPage () {
            InitializeComponent ();
        }
        private void timer (double time) {
            Device.StartTimer (TimeSpan.FromMinutes (1), () => {
                time += 1;
                Label.Text = String.Format ("Travetime :{0}{1}", System.Environment.NewLine, time + "min");

                if (time == 30) {
                    _lblTime.Text = String.Format ("Yopu are too late bro!!!");
                    return false;
                }

                return true;
            });
        }

        private void TimerStarterClicked (object sender, EventArgs e) {
            double time = double.Parse (_EntryTime.Text);

            timer (time);
        }
        private void TimerStarterClicked (object sender, EventArgs e) {
            double time = double.Parse (_EntryTime.Text);

            timer (time);
        }
    }
}