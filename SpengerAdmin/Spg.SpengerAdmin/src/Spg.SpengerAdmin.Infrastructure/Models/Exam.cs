using System;
using System.Collections.Generic;

namespace Spg.SpengerAdmin.Infrastructure.Models;

public partial class Exam
{
    public int Id { get; set; }

    public int Grade { get; set; }

    public int? ClassRoomId { get; set; }

    public int? SubjectId { get; set; }

    public int? TeacherId { get; set; }

    public virtual ClassRoom? ClassRoom { get; set; }

    public virtual Subject? Subject { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
