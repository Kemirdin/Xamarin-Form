using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace XamarinEssentials {
    public partial class MainPage : ContentPage {
        public MainPage () {
            InitializeComponent ();
        }
        protected override void OnAppearing () {
            base.OnAppearing ();
        }

        async void btnCall_Clicked (object sender, System.EventArgs e) {
            if (!string.IsNullOrEmpty (txtNumber.Text)) {
                await Call (txtNumber.Text);
            }

        }

        public async Task Call (string number) {
            try {
                PhoneDialer.Open (number);
            } catch (FeatureNotSupportedException ex) {
                // Phone Dialer is not supported on this device.  
            } catch (Exception ex) {
                // Other error has occurred.  
            }
        }
    }
}