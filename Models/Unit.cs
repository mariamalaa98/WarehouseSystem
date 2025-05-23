using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
