[assembly : ExportRenderer (typeof (CustomNavigationPage), typeof (CustomNavigationPageRenderer))]
namespace CustomFontsNavigationPage.iOS.Renderers {
    public class CustomNavigationPageRenderer : NavigationRenderer {
        protected override void OnElementChanged (VisualElementChangedEventArgs e) {
            base.OnElementChanged (e);

            if (e.NewElement != null) {
                var att = new UITextAttributes ();
                att.Font = UIFont.FromName ("segoesc.ttf", 20);
                UINavigationBar.Appearance.SetTitleTextAttributes (att);
            }
        }
    }
}