namespace Imagge.Models {
    public class Filter : INotifyPropertyChanged {
        public FilterType Type { get; set; }

        public string Name { get; set; }

        public bool IsSelected { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}