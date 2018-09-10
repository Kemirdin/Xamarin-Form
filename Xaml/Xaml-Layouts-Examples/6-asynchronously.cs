public class DemoPage : ContentPage {
    public DemoPage () {
        Content = new StackLayout {
            Children = {
            new Button {
            Text = "PushAsync",
            Command = new Command (() => Navigation.PushAsync (new DemoPage ())),
            },
            new Button {
            Text = "PopAsync",
            Command = new Command (() => Navigation.PopAsync ()),
            },
            new Button {
            Text = "PushModalAsync",
            Command = new Command (() => Navigation.PushModalAsync (new DemoPage ())),
            },
            new Button {
            Text = "PopModalAsync",
            Command = new Command (() => Navigation.PopModalAsync ()),
            },
            new Button {
            Text = "PopToRootAsync",
            Command = new Command (() => Navigation.PopToRootAsync ()),
            },
            },
        };
    }
}