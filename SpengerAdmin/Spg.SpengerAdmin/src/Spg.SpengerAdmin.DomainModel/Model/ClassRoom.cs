namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class ClassRoom : Room
    {
        protected ClassRoom()
        { }
        public ClassRoom(string number, int tableCount, int lockersCount, int level, string building)
            : base(number, tableCount, lockersCount, level, building)
        { }

        private List<Student> _students = new(); // Backing Field
        public virtual IReadOnlyList<Student> Students => _students; // ReadOnly Prop., nur Getter

        private List<Exam> _exams = new();
        public IReadOnlyList<Exam> Exams => _exams;

        // Logik im Domain Model

        public ClassRoom AddStudent(Student student)
        {
            // TODO: Diverse Checks, dafür sorgen, dass nur !!vollständige!! Entitäten geadet werden!
            if (student is not null)
            {
                student.ClassRoomNavigation = this;
                _students.Add(student);
            }
            return this;
        }

        public ClassRoom AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(
                students
                    .Where(s => s is not null)
                        .Select(s => new Student(s, this)
                    )
                );
            return this;
        }
    }
}
