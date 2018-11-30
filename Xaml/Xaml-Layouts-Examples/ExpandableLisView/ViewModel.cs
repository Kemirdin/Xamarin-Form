public class BookItemViewModel : NotifyPropertyChangedBase {
    ...

    private bool showDetails;
    public bool ShowDetails {
        get { return showDetails; }
        set { showDetails = value; OnPropertyChanged (); }
    }
}