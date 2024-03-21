using System;
using System.Collections.Generic;

namespace Spg.SpengerAdmin.Infrastructure.Models;

public partial class ClassRoom
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public int TableCount { get; set; }

    public int LockersCount { get; set; }

    public int Level { get; set; }

    public string Building { get; set; } = null!;

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
