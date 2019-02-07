using SQLite.Net;

namespace 
Sample {
    public interface ISQLite {
        SQLiteConnection GetConnection ();
    }
}