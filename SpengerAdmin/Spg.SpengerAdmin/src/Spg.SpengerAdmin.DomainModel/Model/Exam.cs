namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Exam
    {
        public Exam()
        { }
        public Exam(int grade, ClassRoom classRoomNavigation, Teacher teacherNavigation, Subject subjectNavigation)
        {
            Grade = grade;

            ClassRoomNavigation = classRoomNavigation;
            ClassRoomId = classRoomNavigation.Id;
            TeacherNavigation = teacherNavigation;
            TeacherId = teacherNavigation.Id;
            SubjectNavigation = subjectNavigation;
            SubjectId = subjectNavigation.Id;
        }

        public int Id { get; private set; }
        /// <summary>
        /// Gibt die Note zurück, oder legt diese fest.
        /// </summary>
        /// <remarks>
        /// Details...
        /// </remarks>
        /// <example>
        /// C#-Code
        /// </example>
        /// <exception cref="ArgumentNullException">Wird geworfen, wenn der Parameter <code>null</code> ist.</exception>
        /// <see cref="ClassRoom"/>
        public int Grade { get; set; }

        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoomNavigation { get; } = default!;
        public int SubjectId { get; set; }
        public Subject SubjectNavigation { get; } = default!;
        public int TeacherId { get; set; }
        public Teacher TeacherNavigation { get; } = default!;
    }
}
