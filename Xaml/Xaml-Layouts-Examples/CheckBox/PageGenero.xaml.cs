using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Forms.Controls;

namespace ChecksYRadios {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class PageGenero : ContentPage {
        public PageGenero () {
            InitializeComponent ();

            Inicializar ();
        }

        private void Inicializar () {
            checkBoxGenero.CheckedChanged += CheckBoxGenero_CheckedChanged;
        }

        private void CheckBoxGenero_CheckedChanged (object sender, XLabs.EventArgs<bool> e) {
            var checkbox = sender as CheckBox;

            if (checkbox.Checked) {
                imageGenero.Source = ImageSource.FromResource ("ChecksYRadios.img.hombre.jpg");
            } else {
                imageGenero.Source = ImageSource.FromResource ("ChecksYRadios.img.mujer.jpg");
            }
        }
    }
}