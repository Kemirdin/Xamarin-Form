using System.Collections.Generic;
using System.Linq;
using PCLStorage;
using SQLite;

namespace DevEnvExe_LocalStorage {
    public class SqlHelper {
        static object locker = new object ();
        SQLiteConnection database;