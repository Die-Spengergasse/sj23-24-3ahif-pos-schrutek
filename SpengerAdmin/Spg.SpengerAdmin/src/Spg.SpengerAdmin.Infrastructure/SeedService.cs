using Bogus;
using Spg.SpengerAdmin.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var classRooms = new Faker<Student>().CustomInstantiator((f) => {
                return new Student(
                    f.Random.Enum<Genders>(),
                    f.Name.FirstName(),
                    f.Name.LastName(),
                    f.Date.Between(new DateTime(1950, 01, 01), new DateTime(2010, 01, 01)),
                    f.Internet.Email(), new Address(f.Address.StreetName(),
                    f.Address.BuildingNumber(),
                    f.Address.City(),
                    f.Address.ZipCode()));
            }).Rules((f, s) => {

            });
        }
    }
}
