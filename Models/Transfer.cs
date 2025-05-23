using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class Transfer
{
    public int Id { get; set; }

    public int FromWarehouse { get; set; }

    public int ToWarehouse { get; set; }

    public virtual Warehouse FromWarehouseNavigation { get; set; } = null!;

    public virtual Warehouse ToWarehouseNavigation { get; set; } = null!;

    public virtual ICollection<TransferItem> TransferItems { get; set; } = new List<TransferItem>();
}
