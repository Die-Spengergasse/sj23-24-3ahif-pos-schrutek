using Bogus;
using Spg.SpengerAdmin.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.Infrastructure
{
    public static class FakerExtensions
    {
        public static Student GenerateStudent(this Faker f, bool justFemale)
        {
            Genders gender = f.Random.Enum<Genders>();
            string firstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
            switch (gender)
            {
                case Genders.MALE:
                    firstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
                    if (!justFemale)
                    {
                        firstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
                    }
                    break;
                case Genders.DIVERS:
                case Genders.OTHER:
                    firstName = f.Name.FirstName(f.Random.Enum<Bogus.DataSets.Name.Gender>());
                    break;
            }
            return new Student(
                f.Random.Guid(),
                gender,
                $"{firstName.ToLower()}{f.Random.Int(1000, 9999)}",
                firstName,
                f.Name.LastName(),
                f.Date.Between(new DateTime(1950, 01, 01), new DateTime(2010, 01, 01)),
                f.Internet.Email(),
                new Address(
                    f.Address.StreetName(),
                    f.Address.BuildingNumber(),
                    f.Address.City(),
                    f.Address.ZipCode()));
        }

        public static Exam GenerateExams(this Faker f, ClassRoom classRoom, Teacher teacher, Subject subject)
        {
            return new Exam(f.Random.Int(1, 5), classRoom, teacher, subject);
        }
    }
}
