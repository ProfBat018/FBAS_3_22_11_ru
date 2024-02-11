using System;
using System.Collections.Generic;

namespace EfRelations;

public class GroupDatum: IEntity
{
    public int Id { get; set; } // генерируется автоматически

    public int StudentId { get; set; } // внешний ключ

    public int GroupId { get; set; } // внешний ключ

    public virtual Group Group { get; set; } // не привязано к БД

    public virtual Student Student { get; set; } // не привязано к БД
}
