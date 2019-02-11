using System;
using Xamarin.Forms;

namespace XamarinSQLiteSample {
    public partial class Xamarin_SQLite_SamplePage : ContentPage {
        readonly TodoRepository _db = new TodoRepository ();

        public Xamarin_SQLite_SamplePage () {
            InitializeComponent ();
            list.ItemsSource = _db.GetItems ();
        }

        private void AddClicked (object sender, EventArgs e) {
            if (!String.IsNullOrEmpty (entry.Text)) { //Entry
                var item = new TodoItemModel { Text = entry.Text, CreatedAt = DateTime.Now, Delete = false };
                _db.SaveItem (item);
                list.ItemsSource = _db.GetItems (); //
                entry.Text = "";
            }
        }

        private void DropClicked (object sender, EventArgs e) {
            _db.DeleteAll ();
            list.ItemsSource = _db.GetItems (); //
        }

        private async void ItemTapped (object sender, ItemTappedEventArgs e) {
            var item = (TodoItemModel) e.Item;
            if (await DisplayAlert ("削除してい宜しいですか", item.Text, "OK", "キャンセル")) {
                item.Delete = true; //
                _db.DeleteItem (item); //DB
                list.ItemsSource = _db.GetItems (); //
            }
        }
    }
}