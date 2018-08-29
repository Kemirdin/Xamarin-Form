 public partial class Page1 : ContentPage
    {

     Label labelSuggestion;
        public Page1()
        {
            InitializeComponent();

            labelSuggestion = new Label()
            {
                Text = "Please Click US",

                IsVisible = true,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Green,

            };

            Content = labelSuggestion;

            this.Content = new StackLayout
            {
                Children =
                {
               labelSuggestion

                }
            };


            labelSuggestion.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnLabelClicked()));


        }
        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //    {
        //        await Navigation.PushAsync(new Page2());


        //    }


        private async void OnLabelClicked()
        {
            //var url = "";
            //Device.OpenUri(new Uri(url));


            await Navigation.PushAsync(new Page2());


        }



    }
}