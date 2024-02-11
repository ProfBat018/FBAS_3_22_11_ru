using System;
using System.Collections.Generic;

namespace EfRelations;

public  class Faculty: IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public  ICollection<Group> Groups { get; set; } = new List<Group>();
}
