namespace MyNewApp {
    public partial class MainPage : ContentPage {
        public MainPage () {
            InitializeComponent ();

            this.AnimationView.IsVisible = false;
            this.BtnLogin.Clicked += BtnLogin_Clicked;

        }
        private void BtnLogin_Clicked (object sender, EventArgs e) {

            this.AnimationView.IsVisible = true;
        }
    }
}