public LoginPage ()
{
   InitializeComponent ();
   NavigationPage.SetHasNavigationBar (this, false);
   buttonLogin.Clicked += async (object sender, EventArgs e) => {
   await Navigation.PushAsync (new ActivityFeedPage ());
   }