using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Collections.Demo
{
    public class Person : IEquatable<SchoolClass>, IEquatable<Person>
    {
        public Person(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return Id.Equals(other?.Id);
        }

        public bool Equals(SchoolClass? other)
        {
            return Id.Equals(other?.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() => $"{Id} - {Firstname} {Lastname}";
    }
}
