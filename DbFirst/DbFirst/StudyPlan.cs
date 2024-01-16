using System;
using System.Collections.Generic;

namespace DbFirst;

public class StudyPlan
{
    public int Id { get; set; }

    public int? TeacherId { get; set; }

    public int? GroupId { get; set; }

    public Group? Group { get; set; }

    public Teacher? Teacher { get; set; }
}
