using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class DisposePermission
{
    public int Permid { get; set; }

    public int WarehouseId { get; set; }

    public DateOnly PermissionDate { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<DisposePermissionItem> DisposePermissionItems { get; set; } = new List<DisposePermissionItem>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
