using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class StudentSubject : IEquatable<StudentSubject?>
    {
        protected StudentSubject()
        { }
        public StudentSubject(Student studentNavigation, Subject subjectNavigation, int lesson)
        {
            StudentNavigation = studentNavigation;
            SubjectNavigation = subjectNavigation;
            Lesson = lesson;
        }
        public StudentSubject(int studentNavigationId, int subjectNavigationId, int lesson)
        {
            StudentId = studentNavigationId;
            SubjectId = subjectNavigationId;
            Lesson = lesson;
        }

        //public int Id { get; private set; } // PK
        public int StudentId { get; set; }
        public Student StudentNavigation { get; set; } = default!;
        public int SubjectId { get; set; }
        public Subject SubjectNavigation { get; set; } = default!;
        public int Lesson { get; set; }
        public int? FinalGrade { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as StudentSubject);
        }

        public bool Equals(StudentSubject? other)
        {
            return other is not null &&
                   StudentId == other.StudentId &&
                   SubjectId == other.SubjectId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId, SubjectId);
        }

        public static bool operator ==(StudentSubject? left, StudentSubject? right)
        {
            return EqualityComparer<StudentSubject>.Default.Equals(left, right);
        }

        public static bool operator !=(StudentSubject? left, StudentSubject? right)
        {
            return !(left == right);
        }
    }
}
