using System;
using System.Collections.Generic;

namespace DbFirst;

public class Teacher
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? EmployeeId { get; set; }

    public Employee? Employee { get; set; }

    public Person? Person { get; set; }

    public ICollection<StudyPlan> StudyPlans { get; set; } = new List<StudyPlan>();
}
