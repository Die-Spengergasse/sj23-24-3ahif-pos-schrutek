using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Start
{
    public class Teacher : Person
    {
        public override bool IsFullAged()
            => true;

        public new void DoSomething()
        {
            // Some other nice implemenation
        }
    }
}
