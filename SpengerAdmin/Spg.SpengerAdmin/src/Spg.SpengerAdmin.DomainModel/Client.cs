using Spg.SpengerAdmin.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel
{
    internal class Client
    {
        public void Something()
        {
            ClassRoom classRoom = new ClassRoom("123B", 1, 3, 5, "B");
            classRoom
                .AddStudent(null!)
                .AddStudent(null!)
                .AddStudent(null!)
                .AddStudent(null!);
        }
    }
}
