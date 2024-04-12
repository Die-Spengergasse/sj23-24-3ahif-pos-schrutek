using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Country
    {
        protected Country()
        { }
        public Country(string name)
        {
            Name = name;
        }
        public Country(string name, Address address)
        {
            Name = name;
            Address = address;
        }
        public int Id { get; }
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; }
    }
}
