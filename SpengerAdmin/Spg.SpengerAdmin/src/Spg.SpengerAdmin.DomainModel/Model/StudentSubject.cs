using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class StudentSubject
    {
        protected StudentSubject()
        { }
        public StudentSubject(Student studentNavigation, Subject subjectNavigation, int lesson)
        {
            StudentNavigation = studentNavigation;
            SubjectNavigation = subjectNavigation;
            Lesson = lesson;
        }

        public int Id { get; private set; } // PK
        public Student StudentNavigation { get; set; } = default!;
        public Subject SubjectNavigation { get; set; } = default!;
        public int Lesson { get; set; }
        public int? FinalGrade { get; set; }
    }
}
