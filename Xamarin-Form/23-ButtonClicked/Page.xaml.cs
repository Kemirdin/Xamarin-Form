 public partial class Page1 : ContentPage {
     public Page1 () {
         InitializeComponent ();

         var button = new Button {
             Text = "Hello World",
             BackgroundColor = Color.Black,
             HorizontalOptions = LayoutOptions.Center,
             VerticalOptions = LayoutOptions.Center,
             TextColor = Color.White
         };
         button.Clicked += ButtoncbClicked;
         Content = button;

         this.Content = new StackLayout {
             Children = {
             button

             }
         };

     }

     private async void ButtoncbClicked (object sender, EventArgs e) {
         await Navigation.PushAsync (new Page2 ());
     }

     //private async void buttoncbclicked(object sender, eventargs e)
     //{
     //    await navigation.pushasync(new page2());
     //}

     // This is for Our Xaml Part Button Clicked
     //private async void Button_Clicked(object sender, EventArgs e)
     //{

     //    await Navigation.PushAsync(new Page2());

     //}
 }
 }

 //private void ButtoncbClicked(object sender, EventArgs e)
 //{
 //    await Navigation.PushAsync(new Page2());
 //}

 //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
 //{

 //}