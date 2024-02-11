using System;
using System.Collections.Generic;

namespace EfRelations;

public  class FirstView: IEntity
{
    public string Name { get; set; }

    public int Gpa { get; set; }
}
