﻿using Bogus;
using Spg.SpengerAdmin.DomainModel.Model;

namespace Spg.SpengerAdmin.Infrastructure
{
    public class SeedService
    {
        private readonly SpengerContext _db;

        public SeedService(SpengerContext db)
        {
            _db = db;
        }

        public void Seed()
        {
            var availableSubjects = new string[] { "D", "E", "AM", "POS", "DBI", "RK", "RISL", "PRE", "NVS", "BWM", "NSCS", "SOPK", "WMC", "ETH", "BESP", "GGP", "NW" };
            var buildings = new string[] { "A", "B", "C", "D", };

            var classRooms = new Faker<ClassRoom>().CustomInstantiator(ClassRoom.Seed)
            .Rules((f, c) => 
            {
                c.AddStudents(new Faker<Student>()
                    .CustomInstantiator(f => f.GenerateStudent(true))
                    .Generate(f.Random.Int(15, 30)));
            })
            .Generate(20);
            _db.ClassRooms.AddRange(classRooms);
            _db.SaveChanges();

            var teachers = new Faker<Teacher>().CustomInstantiator(f => 
            {
                Genders gender = f.Random.Enum<Genders>();
                string firstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
                switch (gender)
                {
                    case Genders.MALE:
                        firstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
                        break;
                    case Genders.DIVERS:
                    case Genders.OTHER:
                        firstName = f.Name.FirstName(f.Random.Enum<Bogus.DataSets.Name.Gender>());
                        break;
                }
                return new Teacher(
                    f.Random.Guid(),
                    gender,
                    firstName,
                    f.Name.LastName(),
                    f.Date.Between(new DateTime(1950, 01, 01), new DateTime(2010, 01, 01)),
                    f.Internet.Email(),
                    new Address(
                            f.Address.StreetName(),
                            f.Address.BuildingNumber(),
                            f.Address.City(),
                            f.Address.ZipCode()),
                    f.Random.Decimal(3400, 6000)
                );

            }).Generate(50);
            _db.Teachers.AddRange(teachers);
            _db.SaveChanges();

            _db.Subjects.AddRange(availableSubjects.Select(s => new Subject(s)));
            _db.SaveChanges();

            var studentSubjects = new Faker<StudentSubject>().CustomInstantiator(f =>
            {
                return new StudentSubject(
                    f.Random.ListItem(_db.Students.ToList()),
                    f.Random.ListItem(_db.Subjects.ToList()),
                    f.Random.Int(1, 16));
            })
            .Rules((f, s) =>
            {
                s.FinalGrade = f.Random.Int(1, 5).OrNull(f, 0.5F);
            })
            .Generate(600)
            .GroupBy(t => new { StudentId = t.StudentNavigation.Id, SubjectId = t.SubjectNavigation.Id })
            .Select(g => g.First());
            _db.StudentSubjects.AddRange(studentSubjects);
            _db.SaveChanges();


            var exams = new Faker<Exam>().CustomInstantiator(f => 
            {
                return f.GenerateExams(
                    f.Random.ListItem(_db.ClassRooms.ToList()), 
                    f.Random.ListItem(_db.Teachers.ToList()), 
                    f.Random.ListItem(_db.Subjects.ToList()));
            })
            .Generate(2400);
            _db.Exams.AddRange(exams);
            _db.SaveChanges();
        }
    }
}
