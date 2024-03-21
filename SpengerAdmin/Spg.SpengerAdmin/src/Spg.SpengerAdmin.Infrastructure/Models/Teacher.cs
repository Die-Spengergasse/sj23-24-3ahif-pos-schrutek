using System;
using System.Collections.Generic;

namespace Spg.SpengerAdmin.Infrastructure.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string Income { get; set; } = null!;

    public int Gender { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string AddressStreet { get; set; } = null!;

    public string AddressHouseNumber { get; set; } = null!;

    public string AddressCity { get; set; } = null!;

    public string AddressZipCode { get; set; } = null!;

    public string? Occupation { get; set; }

    public string? Handicap { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
