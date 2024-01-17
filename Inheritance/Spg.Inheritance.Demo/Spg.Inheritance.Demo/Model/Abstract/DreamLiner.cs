using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Inheritance.Demo.Model.Abstract
{
    public class DreamLiner : FlightDevice
    {
        public DreamLiner(int passengers) 
            : base(passengers)
        { }

        public override void Start()
        {
            Console.WriteLine("0kmh auf 300");
        }

        public override void Land()
        {
            Console.WriteLine("300kmh auf 0kmh");
        }
    }
}
