using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? Warehouseid { get; set; }

    public int? Unitid { get; set; }

    public virtual ICollection<DisposePermissionItem> DisposePermissionItems { get; set; } = new List<DisposePermissionItem>();

    public virtual ICollection<SupplierPermissionItem> SupplierPermissionItems { get; set; } = new List<SupplierPermissionItem>();

    public virtual ICollection<TransferItem> TransferItems { get; set; } = new List<TransferItem>();

    public virtual Unit? Unit { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
