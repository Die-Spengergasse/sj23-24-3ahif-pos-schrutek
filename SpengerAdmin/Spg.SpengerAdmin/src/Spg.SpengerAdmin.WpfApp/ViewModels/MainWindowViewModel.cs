using Spg.SpengerAdmin.DomainModel.Model;
using Spg.SpengerAdmin.WpfApp.Services;

namespace Spg.SpengerAdmin.WpfApp.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly StudentService _studentService;
        private readonly ClassRoomService _classroomService;

        public MainWindowViewModel(
            StudentService studentService, 
            ClassRoomService classroomService)
        {
            _studentService = studentService;
            _classroomService = classroomService;

            Students = _studentService.GetAll();
            ClassRooms = _classroomService.GetAll();
        }

        public List<ClassRoom> ClassRooms { get; set; } = new();

        public List<Student> Students { get; set; } = new();
    }
}