namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Exam
    {
        /// <summary>
        /// Gibt die ID zurück, oder legt diese fest.
        /// </summary>
        /// <remarks>
        /// Details...
        /// </remarks>
        /// <example>
        /// C#-Code
        /// </example>
        /// <exception cref="ArgumentNullException">Wird geworfen, wenn der Parameter <code>null</code> ist.</exception>
        /// <see cref="ClassRoom"/>
        public int Id { get; }
        /// <summary>
        /// Note
        /// </summary>
        public int Grade { get; set; }

        public ClassRoom ClassRoomNavigation { get; } = default!;

        public Subject SubjectNavigation { get; } = default!;

        public Teacher TeacherNavigation { get; } = default!;
    }
}
