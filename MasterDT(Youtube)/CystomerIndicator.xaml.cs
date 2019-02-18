 public partial class CustomIndicator : ContentView
    {
        public CustomIndicator()
        {
            InitializeComponent();
            this.webView.Source= new HtmlWebViewSource { Html = "<html><body><img src='loading.gif' style='position: absolute; top: 0; left: 0; right: 0; bottom: 50; margin: auto;' /></body></html>" };
        }
    }
}