﻿using System;
using System.Collections.Generic;

namespace EfRelations;

public class StudyPlan: IEntity
{
    public int Id { get; set; }

    public int TeacherId { get; set; }

    public int GroupId { get; set; }

    public virtual Group Group { get; set; }

    public virtual Teacher Teacher { get; set; }
}
