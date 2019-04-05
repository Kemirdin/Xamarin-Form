//Property to hold the selected picker item
private PickerItem _SelectedMotherTounge;
public PickerItem SelectedMotherTounge {
    get { return _SelectedMotherTounge; }
    set {
        //Method which notifies the property change
        SetProperty (ref _SelectedMotherTounge, value);
    }
}

//fill the observable collection as per requirement
public ObservableCollection<PickerItem> Languages = new ObservableCollection<PickerItem> ();
//Add some items, from DB or service or whatever

//Get the selected values - from Languages ObservableCollection
//For demo purpose hard-coded value as English, this would the value selected by user.
SelectedMotherTounge = GetSelectedItemFromCollection (Languages, "English");

//Got the selected item, now get the id from the same
var selectedItemId = SelectedMotherTounge.Id;

//function to get the selected picker item from the bound collection
public static PickerItem
GetSelectedItemFromCollection (ObservableCollection<PickerItem> collection, string FindByName) {
    PickerItem filteredItems =
        collection.FirstOrDefault (x => x.Name.ToLower ().Trim ().Equals (FindByName.ToLower ().Trim ()));
    return filteredItems;
}