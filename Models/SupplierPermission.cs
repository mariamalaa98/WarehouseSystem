using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class SupplierPermission
{
    public int Id { get; set; }

    public int Warehouse { get; set; }

    public DateOnly PermissionDate { get; set; }

    public int SupplierId { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierPermissionItem> SupplierPermissionItems { get; set; } = new List<SupplierPermissionItem>();

    public virtual Warehouse WarehouseNavigation { get; set; } = null!;
}
