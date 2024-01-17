using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Start
{

    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual bool IsFullAged() 
            => false;

        public void DoSomething()
        {
            // Nice Implementation
        }

        public Person(DateTime geburtsdatum, string name, int id)
        {
            Id = id;
        }

        public Person()
            : base()
        { }

        public override string ToString()
        {
            return base.ToString() + " mit der Id: " + Id;
        }
    }
}
