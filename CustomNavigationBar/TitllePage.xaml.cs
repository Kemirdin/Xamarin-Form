using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomNavigationBarSample {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class Title
    Page : ContentPage {
        public TitleImagePage () {

            CustomNavigationPage.SetTitleBackground (this, "icon");
            CustomNavigationPage.SetTitlePosition (this, CustomNavigationPage.TitleAlignment.Center);
            InitializeComponent ();
        }
    }
}