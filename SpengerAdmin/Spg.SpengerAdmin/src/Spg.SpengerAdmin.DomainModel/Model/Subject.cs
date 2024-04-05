namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Subject
    {
        private Subject()
        { }
        public Subject(string name)
        {
            Name = name;
        }
        public Subject(Subject subject)
        {
            Name = subject.Name;
        }

        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;


        private List<Exam> _exams = new();
        public IReadOnlyList<Exam> Exams => _exams;

        private List<StudentSubject> _sudentSubjects = new();
        public IReadOnlyList<StudentSubject> StudentSubjects => _sudentSubjects;
    }
}
