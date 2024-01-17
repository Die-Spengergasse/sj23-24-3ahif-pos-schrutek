using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PropertiesExercise.Model
{
    public enum Genders { Male, Female, Other }

    public class Teacher
    {
        public Genders Gender { get; set; }
        public string? FirstName { get; }
        public string? LastName { get; }

        public string LongName => $"{FirstName} {LastName}";
        public string ShortName1 => LastName?.Length > 3 ? LastName.ToUpper() : LastName?.Substring(0, 3).ToUpper() ?? string.Empty;
        public string ShortName2 => LastName?.Substring(0, Math.Min(3, LastName!.Length)).ToUpper() ?? string.Empty;
        public string ShortName3 => LastName?.PadLeft(3, ' ').Substring(0, 3).Trim().ToUpper() ?? string.Empty;

        public string? EMail { get; set; }
        public bool IsSchoolEMail => EMail?.EndsWith("@spengergasse.at") ?? false;

        public decimal? Salary
        {
            get { return _salary; }
            set 
            {
                if (!_salary.HasValue)
                {
                    _salary = value;
                }
            }
        }
        private decimal? _salary;

        public decimal NetSalary => (_salary ?? 0) * 0.8M;

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
