using Spg.SpengerAdmin.DomainModel.Model;
using Spg.SpengerAdmin.Infrastructure;

namespace Spg.SpengerAdmin.WpfApp.Services
{
    public class ClassRoomService
    {
        private readonly SpengerContext _db;

        public ClassRoomService(SpengerContext db)
        {
            _db = db;
        }

        internal List<ClassRoom> GetAll()
        {
            return _db.ClassRooms
                .Where(c => c.Number.StartsWith("A"))
                .OrderByDescending(c => c.Number)
                .ToList();
        }
    }
}
