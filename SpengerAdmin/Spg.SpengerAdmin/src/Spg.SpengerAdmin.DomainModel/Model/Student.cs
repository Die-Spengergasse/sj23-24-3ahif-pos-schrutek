namespace Spg.SpengerAdmin.DomainModel.Model
{
    public partial class Student : Person
    {
        protected Student()
            : base()
        { }
        public Student(Guid guid,
            Genders gender, string username, string firstName, string lastName,
            DateTime birthDate, string eMailAddress,
            Address address)
            : base(guid, gender, firstName, lastName, birthDate, eMailAddress, address)
        {
            Username = username;
        }
        public Student(Student student, ClassRoom classroom)
            : base(student.Guid, student.Gender, student.FirstName, student.LastName, 
                  student.BirthDate, student.EMailAddress, student.Address)
        {
            Username = student.Username;
            ClassRoomNavigation = classroom;
        }

        public string Username { get; private set; }
        public int ClassRoomNavigationId { get; set; }
        public ClassRoom ClassRoomNavigation { get; set; } = default!;

        private List<StudentSubject> _sudentSubjects = new();
        public IReadOnlyList<StudentSubject> StudentSubjects => _sudentSubjects;

        public Student AddSubject(Subject subject)
        {
            if (subject is not null)
            {
                subject.StudentNavigation = this;
                _subjects.Add(subject);
            }
            return this;
        }

        public Student AddSubjects(IEnumerable<Subject> subjects)
        {
            _subjects.AddRange(
                subjects
                    .Where(s => s is not null)
                        .Select(s => new Subject(s, this)
                    )
                );
            return this;
        }
    }
}