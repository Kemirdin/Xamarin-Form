using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyListView.Views {
    public partial class HumanPage : ContentPage {
        public HumanPage () {
            InitializeComponent ();
            BindingContext = new ViewModels.HumanViewModels ();
        }
    }
}