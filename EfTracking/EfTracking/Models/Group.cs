using System;
using System.Collections.Generic;

namespace EfTracking.Models;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Course { get; set; }

    public int? FacultyId { get; set; }

    public virtual Faculty? Faculty { get; set; }

    public virtual ICollection<GroupsDatum> GroupsData { get; set; } = new List<GroupsDatum>();

    public virtual ICollection<StudyPlan> StudyPlans { get; set; } = new List<StudyPlan>();
}
