public class MenuPage : ContentPage {
    public MenuPage () {
        Content = new StackLayout {
            Padding = new Thickness (0, Device.OnPlatform<int> (20, 0, 0), 0, 0),
            Children = {
            new MainLink ("Page A"),
            new MainLink ("Page B"),
            new MainLink ("Page C"),
            }
        };
        Title = "Master";
        BackgroundColor = Color.Gray.WithLuminosity (0.9);
        Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
    }
}