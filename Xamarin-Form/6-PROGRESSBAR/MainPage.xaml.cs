using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeWebView {
    public partial class MainPage : ContentPage {
        public MainPage () {
            InitializeComponent ();
            browser.Source = "https://giphy.com/search/smiling";
        }

        void WebOnNavigating (object sender, WebNavigatingEventArgs s) {
            loading.IsVisible = true;
        }

        void WebOnNavigated (object sender, WebNavigationEventArgs s) {
            loading.IsVisible = false;

        }

    }
}