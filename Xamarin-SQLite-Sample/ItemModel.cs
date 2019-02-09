using System;
using SQLite.Net.Attributes;

namespace XamarinSQLite {
    public class TodoItemModel {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } //make date
        public bool Delete { get; set; } //delete items
    }
}