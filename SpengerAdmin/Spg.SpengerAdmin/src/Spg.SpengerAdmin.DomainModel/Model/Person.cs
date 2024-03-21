﻿namespace Spg.SpengerAdmin.DomainModel.Model
{
    public enum Genders { MALE = 0, FEMALE = 1, DIVERS = 3, OTHER = 2, UNKNOWN = 99 }

    public abstract class Person
    {
        protected Person()
        { }
        public Person(
            Genders gender, string firstName, string lastName, 
            DateTime birthDate, string eMailAddress, 
            Address address)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EMailAddress = eMailAddress;
            Address = address;
        }

        public int Id { get; private set; }
        public Genders Gender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; }
        public string EMailAddress { get; } = string.Empty;
        public Address Address { get; set; } = default!;
        public string? Occupation { get; set; } = string.Empty;
        public string? Handicap { get; set; }

        public string GreetingLabel => $"{FirstName} {LastName}";
    }
}
