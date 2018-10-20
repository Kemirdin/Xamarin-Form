using System;
using SQLite;

namespace XamarinFormsLocalDb {
    public class Employee {
        [PrimaryKey, AutoIncrement]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Age { get; set; }
    }
}