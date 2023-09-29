using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Start
{
    public class Person
    {
        #region Java
        // Java Stil start get+set
        private String name;
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            if (name.Length <= 2)
            {
                throw new ArgumentException("Name zu kurz!");
            }
            this.name = name;
        }
        // Java Stil Ende
        #endregion Java

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

        public Person(DateTime geburtsdatum, string name)
        {
            Geburtsdatum = geburtsdatum;
            setName(name);
        }

        public override string? ToString()
        {
            return getName() + " " + Geburtsdatum; 
        }
    }

    public class Schueler : Person
    {
        public int Id { get; set; }
        public Schueler(DateTime geburtsdatum, string name, int id) : base(geburtsdatum, name)
        {
            Id = id;
        }

        public override string ToString()
        {
            return base.ToString() + " mit der Id: " + Id;
        }
    }
}
