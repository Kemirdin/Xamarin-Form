List<string> templist = new List<string> () { "Item 1", "Item 2", "Item 3", "Item 4" };

public List () {
    InitializeComponent ();
    lst.ItemsSource = templist;
}

private void More_Clicked (object sender, EventArgs e) {
    var name = (sender as MenuItem).CommandParameter as string;
    DisplayAlert ("Context Action", name, "ok");
}