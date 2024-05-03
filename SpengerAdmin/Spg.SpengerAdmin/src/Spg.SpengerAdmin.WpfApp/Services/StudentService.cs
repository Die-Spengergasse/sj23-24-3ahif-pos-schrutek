using Spg.SpengerAdmin.DomainModel.Model;
using Spg.SpengerAdmin.Infrastructure;

namespace Spg.SpengerAdmin.WpfApp.Services
{
    public class StudentService
    {
        private readonly SpengerContext _db;

        public StudentService(SpengerContext db)
        {
            _db = db;
        }

        public List<Student> GetAll()
        {
            return _db.Students.ToList();
        }
    }
}
