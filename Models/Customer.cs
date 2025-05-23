using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? HomePhone { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Mail { get; set; }

    public string? Website { get; set; }

    public virtual ICollection<DisposePermission> DisposePermissions { get; set; } = new List<DisposePermission>();
}
