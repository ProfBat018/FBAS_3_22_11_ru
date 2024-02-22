﻿using System;
using System.Collections.Generic;

namespace Loadings;

public partial class GroupsDatum
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? GroupId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Student? Student { get; set; }
}