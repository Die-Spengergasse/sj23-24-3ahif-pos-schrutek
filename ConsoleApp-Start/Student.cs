namespace ConsoleApp_Start
{
    public class Student : Person
    {


        public string EMail { get; set; }

        public int Age { get; set; }

        public override bool IsFullAged()
            => (DateTime.Now.Year - _geburtsdatum.Year) > 18;

        // C# Stil mit Properties
        private DateTime _geburtsdatum; // Convention _ for private fields
        public DateTime Geburtsdatum
        {
            get
            {
                return _geburtsdatum;
            }
            set
            {
                _geburtsdatum = value;
            }
        }

        // Property with a hidden field
        public int AlterInJahren
        {
            get
            {
                return 0; // bessere Loesung?
            }
        }

        public Student()
        { }

        public Student(DateTime geburtsdatum, string name)
        {
            Geburtsdatum = geburtsdatum;
        }
    }
}
