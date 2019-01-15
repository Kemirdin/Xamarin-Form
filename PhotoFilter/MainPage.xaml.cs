using myfolder.ViewModels;
using Xamarin.Forms;

namespace myfolder {
    public partial class MainPage : ContentPage {
        public MainPage () {
            InitializeComponent ();
            BindingContext = new MainPageViewModel ();

        }
    }
}