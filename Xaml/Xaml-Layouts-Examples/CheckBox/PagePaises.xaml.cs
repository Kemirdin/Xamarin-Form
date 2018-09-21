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
    public partial class PagePaises : ContentPage {
        string[] imagenes = { "argentina.png", "chile.png", "colombia.jpg", "espana.png", "peru.png", "venezuela.png" };
        string[] paises = { "Argentina", "Chile", "Colombia", "España", "Perú", "Venezuela" };
        public PagePaises () {
            InitializeComponent ();

            Inicializar ();
        }

        private void Inicializar () {
            bindableRadioGroupPaises.ItemsSource = paises;

            bindableRadioGroupPaises.CheckedChanged += BindableRadioGroupPaises_CheckedChanged;
        }

        private void BindableRadioGroupPaises_CheckedChanged (object sender, int e) {
            var radio = sender as CustomRadioButton;

            if (radio == null || radio.Id == -1) {
                return;
            }

            imagePais.Source = ImageSource.FromResource ("ChecksYRadios.img." + imagenes[radio.Id]);
        }
    }
}