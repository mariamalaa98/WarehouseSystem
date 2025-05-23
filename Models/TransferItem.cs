using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class TransferItem
{
    public int TransferId { get; set; }

    public int ItemId { get; set; }

    public int SupplierId { get; set; }

    public DateOnly ProductionDate { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Transfer Transfer { get; set; } = null!;
}
