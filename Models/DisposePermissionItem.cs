using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class DisposePermissionItem
{
    public int DisposePermissionId { get; set; }

    public int ItemId { get; set; }

    public int SupplierId { get; set; }

    public virtual DisposePermission DisposePermission { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
