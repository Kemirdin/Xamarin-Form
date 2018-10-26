public class DataManager {
    SQLiteConnection db;

    public DataManager () {
        db = new SQLiteConnection (DependencyService.Get<IFileHelper> ().GetLocalFilePath ("database.db"));
        db.CreateTable<Item> ();
    }

    public ObservableCollection<ItemViewModel> GetItems () {
        var itemQuery = db.Table<Item> ();

        var items = new ObservableCollection<ItemViewModel> ();

        foreach (var item in itemQuery)
            items.Add (new ItemViewModel (item));

        return items;
    }

    public void SaveItem (ItemViewModel itemViewModel) {
        var item = itemViewModel.Model;

        db.Insert (item);
    }
}