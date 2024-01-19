using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.LambdaDemo.App.Model
{
    public class StudentList : List<Student>
    {
        public StudentList Filter(Func<Student, bool> predicate)
        {
            StudentList result = new();
            foreach (Student student in this)
            {
                if (predicate(student))
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}
