using System.IO;
using Xamarin.Forms;
using XamarinSQLiteSample.Droid;

[assembly : Dependency (typeof (SQLite_Android))]
namespace XamarinSQLiteSample.Droid {
    public class SQLite_Android : ISQLite {
        public SQLite.Net.SQLiteConnection GetConnection () {
            const string sqliteFilename = "TodoSQLite.db3"; //name of DARA
            var documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal); //Documents file
            var path = Path.Combine (documentsPath, sqliteFilename); //DB file PATH
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid ();
            var conn = new SQLite.Net.SQLiteConnection (plat, path);
            return conn;
        }
    }
}