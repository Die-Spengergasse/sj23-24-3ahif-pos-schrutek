namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Subject
    {
        public int Id { get; }
        public string Name { get; set; } = string.Empty;


        private List<Exam> _exams = new();
        public IReadOnlyList<Exam> Exams => _exams;

        public Student StudentNavigation { get; } = default!;
    }
}
