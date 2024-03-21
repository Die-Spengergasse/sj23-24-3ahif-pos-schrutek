using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spg.SpengerAdmin.Infrastructure.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? StudentId { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual Student? Student { get; set; }
}
