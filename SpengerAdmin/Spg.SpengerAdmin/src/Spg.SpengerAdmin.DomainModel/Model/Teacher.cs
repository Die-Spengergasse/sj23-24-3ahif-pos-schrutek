namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Teacher : Person
    {
        public Teacher(
            Genders gender, string firstName, string lastName,
            DateTime birthDate, string eMailAddress,
            Address address, decimal income)
            : base(gender, firstName, lastName, birthDate, eMailAddress, address)
        {
            Income = income;
        }

        public decimal Income { get; set; }


        private List<Exam> _exams = new();
        public IReadOnlyList<Exam> Exams => _exams;
    }
}
