namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Student : Person
    {
        protected Student()
            : base()
        { }
        public Student(
            Genders gender, string firstName, string lastName,
            DateTime birthDate, string eMailAddress,
            Address address)
            : base(gender, firstName, lastName, birthDate, eMailAddress, address)
        { }

        public ClassRoom ClassRoomNavigation
        {
            get { return _classRoomNavigation; }
            set 
            {
                if (value is not null)
                {
                    _classRoomNavigation = value;
                }
            }
        }
        private ClassRoom _classRoomNavigation;

        private List<Subject> _subjects = new();
        public IReadOnlyList<Subject> Subjects => _subjects;
    }
}