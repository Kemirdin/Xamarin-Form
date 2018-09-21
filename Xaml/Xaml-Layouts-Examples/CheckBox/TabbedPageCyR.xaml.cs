using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChecksYRadios {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class TabbedPageCyR : TabbedPage {
        public TabbedPageCyR () {
            InitializeComponent ();

            Inicializar ();
        }

        private void Inicializar () {
            Children.Add (new PageGenero ());
            Children.Add (new PagePaises ());
        }
    }
}