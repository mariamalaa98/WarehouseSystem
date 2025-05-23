using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class SupplierPermissionItem
{
    public int SupplierPermissionId { get; set; }

    public int ItemId { get; set; }

    public DateOnly ProductionDate { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual SupplierPermission SupplierPermission { get; set; } = null!;
}
