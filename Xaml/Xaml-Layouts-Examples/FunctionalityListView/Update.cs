namespace TravelRecordApp {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage {
        HistoryVM viewModel;
        public HistoryPage () {
            InitializeComponent ();

            viewModel = new HistoryVM ();
            BindingContext = viewModel;
        }

        protected override void OnAppearing () {
            base.OnAppearing ();

            viewModel.UpdatePosts ();
        }
    }
}