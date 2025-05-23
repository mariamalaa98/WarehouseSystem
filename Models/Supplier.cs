using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? HomePhone { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Mail { get; set; }

    public string? Website { get; set; }

    public virtual ICollection<DisposePermissionItem> DisposePermissionItems { get; set; } = new List<DisposePermissionItem>();

    public virtual ICollection<SupplierPermission> SupplierPermissions { get; set; } = new List<SupplierPermission>();

    public virtual ICollection<TransferItem> TransferItems { get; set; } = new List<TransferItem>();
}
