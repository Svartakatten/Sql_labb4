using System;
using System.Collections.Generic;

namespace Sql_labb4.Models;

public partial class StudentGrade
{
    public int EnrollmentId { get; set; }

    public int CourseId { get; set; }

    public int StudentId { get; set; }

    public int? Grade { get; set; }

    public string? Teacher { get; set; }

    public DateTime? Published { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Person Student { get; set; } = null!;
}
