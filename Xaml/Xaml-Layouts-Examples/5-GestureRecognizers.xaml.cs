using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageExample {
    public partial class Page1 : ContentPage {
        public Page1 () {
            InitializeComponent ();
            img1.GestureRecognizers.Add ((new TapGestureRecognizer ((view) => OnImageClicked1 ())));
            img2.GestureRecognizers.Add ((new TapGestureRecognizer ((view) => OnImageClicked2 ())));
            img3.GestureRecognizers.Add ((new TapGestureRecognizer ((view) => OnImageClicked3 ())));
        }
        public void OnImageClicked3 () {
            imgmain.Source = img3.Source;
        }

        public void OnImageClicked2 () {
            imgmain.Source = img2.Source;
        }

        public void OnImageClicked1 () {
            imgmain.Source = img1.Source;
        }
    }
}