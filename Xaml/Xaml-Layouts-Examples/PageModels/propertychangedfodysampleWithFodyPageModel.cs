using System.ComponentModel;

namespace propertychangedfodysample {
    public class propertychangedfodysampleWithFodyPageModel : INotifyPropertyChanged {
        public string SampleText {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}