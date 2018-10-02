namespace Data_Entry {
    public sealed class Member {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }

        public Member (string firstName, string middleName, string lastName, DateTime dateTime) {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateTime = dateTime;
        }
    }
}