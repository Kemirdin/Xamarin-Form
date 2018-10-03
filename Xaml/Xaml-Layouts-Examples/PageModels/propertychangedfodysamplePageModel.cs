using System.ComponentModel;

namespace propertychangedfodysample {
    public class propertychangedfodysamplePageModel : INotifyPropertyChanged {
        private string _sampleText;

        public string SampleText {
            get { return _sampleText; }
            set {
                _sampleText = value;
                OnPropertyChanged (nameof (SampleText));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged (string name) {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null) {
                handler (this, new PropertyChangedEventArgs (name));
            }
        }
    }
}