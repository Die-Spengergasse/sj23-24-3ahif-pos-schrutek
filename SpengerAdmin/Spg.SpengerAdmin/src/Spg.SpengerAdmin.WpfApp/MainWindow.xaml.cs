using Microsoft.EntityFrameworkCore;
using Spg.SpengerAdmin.Infrastructure;
using Spg.SpengerAdmin.WpfApp.Services;
using Spg.SpengerAdmin.WpfApp.ViewModels;
using System.Windows;

namespace Spg.SpengerAdmin.WpfApp
{
    /// <summary>
    /// Hier sollte idealerweise keine Logik stehen!!!!!!!
    /// Diese kommt komplett ins View Model.
    /// Außer: Was ist überhaupt mein View Model + Dependency Injection
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Legt das VM für das XAML fest
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite("Data Source = .\\..\\..\\..\\..\\..\\SpengerAdmin.db")
                .Options;

            SpengerContext db = new SpengerContext(options);
            DataContext = new MainWindowViewModel(
                new StudentService(db), 
                new ClassRoomService(db)
            );
        }
    }
}