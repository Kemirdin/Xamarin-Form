using System;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;
using XamarinSQLiteSample.iOS;

[assembly : Dependency (typeof (SQLite_iOS))]
namespace XamarinSQLiteSample.iOS {
    public class SQLite_iOS : ISQLite {
        public SQLiteConnection GetConnection () {
            const string sqliteFilename = "TodoSQLite.db3"; //NAme of Data
            var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); //Documentsフォルダ
            var libraryPath = Path.Combine (documentsPath, "..", "Library"); // Project file
            var path = Path.Combine (libraryPath, sqliteFilename); //DBfile Path
            var plat = new SQLitePlatformIOS ();
            var conn = new SQLiteConnection (plat, path);
            return conn;
        }
    }
}