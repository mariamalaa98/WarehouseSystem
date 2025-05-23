using System;
using System.Collections.Generic;

namespace EF_Desktop_project.Models;

public partial class Warehouse
{
    //parametrized constructor


    public Warehouse(string name, string address, int? managerId)
    {
        Name = name;
        Address = address;
        ManagerId = managerId;
    }
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int? ManagerId { get; set; }

    public virtual ICollection<DisposePermission> DisposePermissions { get; set; } = new List<DisposePermission>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Manager? Manager { get; set; }

    public virtual ICollection<SupplierPermission> SupplierPermissions { get; set; } = new List<SupplierPermission>();

    public virtual ICollection<Transfer> TransferFromWarehouseNavigations { get; set; } = new List<Transfer>();

    public virtual ICollection<Transfer> TransferToWarehouseNavigations { get; set; } = new List<Transfer>();
}
