using System.Collections.Generic;
using SQLite.Net;
using Xamarin.Forms;

namespace XamarinSQLiteSample {
    public class TodoRepository {
        static readonly object Locker = new object ();
        readonly SQLiteConnection _db;

        public TodoRepository () {
            _db = DependencyService.Get<ISQLite> ().GetConnection (); //data base connect
            _db.CreateTable<TodoItemModel> (); //make table
        }
        
        public IEnumerable<TodoItemModel> GetItems () {
            lock (Locker) {
                //Delete==false
                return _db.Table<TodoItemModel> ().Where (m => m.Delete == false);
            }
        }
        //uodate
        public int SaveItem (TodoItemModel item) {
            lock (Locker) {
                if (item.ID != 0) { //ID is null update
                    _db.Update (item);
                    return item.ID;
                }
                return _db.Insert (item); //inserting 
            }
        }

        public int DeleteItem (TodoItemModel item) {
            lock (Locker) {
                return _db.Delete (item); //silmek
            }
        }

        public int DeleteAll () {
            lock (Locker) {
                return _db.DeleteAll<TodoItemModel> ();
            }
        }
    }
}