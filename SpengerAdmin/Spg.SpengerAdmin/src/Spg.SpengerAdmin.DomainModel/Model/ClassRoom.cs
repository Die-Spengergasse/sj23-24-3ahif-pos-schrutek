namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class ClassRoom
    {
        // Id ... P.K. ; int/long ... Auto Increment (Convention over Configuration)
        // ID kommt IMMER aus der DB.
        public int Id { get; }
        public string Number { get; set; } = string.Empty;
        public int TableCount { get; set; }
        public int LockersCount { get; set; }
        public int Level { get; set; }
        public string Building { get; set; } = string.Empty;


        public ClassRoom(string number, int tableCount, int lockersCount, int level, string building)
        {
            Number = number;
            TableCount = tableCount;
            LockersCount = lockersCount;
            Level = level;
            Building = building;
        }

        private List<Student> _students = new(); // Backing Field
        public IReadOnlyList<Student> Students => _students; // ReadOnly Prop., nur Getter

        private List<Exam> _exams = new();
        public IReadOnlyList<Exam> Exams => _exams;

        // Logik im Domain Model

        public ClassRoom AddStudent(Student student)
        {
            // TODO: Diverse Checks, dafür sorgen, dass nur !!vollständige!! Entitäten geaddet werden!
            if (student is not null)
            {
                student.ClassRoomNavigation = this;
                _students.Add(student);
            }
            return this;
        }

        public ClassRoom RemoveStudent(Student student)
        {
            // TODO: Implementation
            return this;
        }
    }
}
