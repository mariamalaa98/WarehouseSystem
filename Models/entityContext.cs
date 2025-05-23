using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_Desktop_project.Models;

public partial class EntityContext : DbContext
{
    public EntityContext()
    {
    }

    public EntityContext(DbContextOptions<EntityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DisposePermission> DisposePermissions { get; set; }

    public virtual DbSet<DisposePermissionItem> DisposePermissionItems { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierPermission> SupplierPermissions { get; set; }

    public virtual DbSet<SupplierPermissionItem> SupplierPermissionItems { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    public virtual DbSet<TransferItem> TransferItems { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-ELSM1IU\\SQLEXPRESS;Initial Catalog=entity;Integrated Security=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F7F787A0B");

            entity.ToTable("customer");

            entity.HasIndex(e => e.Mail, "UQ__customer__7A2129048F48C423").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("home_phone");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<DisposePermission>(entity =>
        {
            entity.HasKey(e => e.Permid).HasName("PK__dispose___367AF50FD6056C6D");

            entity.ToTable("dispose_permission");

            entity.Property(e => e.Permid).HasColumnName("permid");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.PermissionDate).HasColumnName("permission_date");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.DisposePermissions)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__dispose_p__custo__76969D2E");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.DisposePermissions)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__dispose_p__wareh__75A278F5");
        });

        modelBuilder.Entity<DisposePermissionItem>(entity =>
        {
            entity.HasKey(e => new { e.DisposePermissionId, e.ItemId, e.SupplierId }).HasName("PK__dispose___75B45F6B0BCBE8CD");

            entity.ToTable("dispose_permission_item");

            entity.Property(e => e.DisposePermissionId).HasColumnName("dispose_permission_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

            entity.HasOne(d => d.DisposePermission).WithMany(p => p.DisposePermissionItems)
                .HasForeignKey(d => d.DisposePermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__dispose_p__dispo__7A672E12");

            entity.HasOne(d => d.Item).WithMany(p => p.DisposePermissionItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__dispose_p__item___7B5B524B");

            entity.HasOne(d => d.Supplier).WithMany(p => p.DisposePermissionItems)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__dispose_p__suppl__7C4F7684");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__items__52020FDD32F5BB19");

            entity.ToTable("items");

            entity.HasIndex(e => e.Code, "UQ__items__357D4CF995469E31").IsUnique();

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Unitid).HasColumnName("unitid");
            entity.Property(e => e.Warehouseid).HasColumnName("warehouseid");

            entity.HasOne(d => d.Unit).WithMany(p => p.Items)
                .HasForeignKey(d => d.Unitid)
                .HasConstraintName("FK__items__unitid__656C112C");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Items)
                .HasForeignKey(d => d.Warehouseid)
                .HasConstraintName("FK__items__warehouse__6477ECF3");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__managers__3213E83F17E44406");

            entity.ToTable("managers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Supplier__3213E83F41FAD0E9");

            entity.ToTable("Supplier");

            entity.HasIndex(e => e.Mail, "UQ__Supplier__7A212904AAA8CA84").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("home_phone");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<SupplierPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__supplier__3213E83FC1F85A3D");

            entity.ToTable("supplier_permission");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionDate).HasColumnName("permission_date");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.Warehouse).HasColumnName("warehouse");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierPermissions)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__supplier___suppl__6EF57B66");

            entity.HasOne(d => d.WarehouseNavigation).WithMany(p => p.SupplierPermissions)
                .HasForeignKey(d => d.Warehouse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__supplier___wareh__6E01572D");
        });

        modelBuilder.Entity<SupplierPermissionItem>(entity =>
        {
            entity.HasKey(e => new { e.SupplierPermissionId, e.ItemId }).HasName("PK__supplier__343CBB203723B671");

            entity.ToTable("supplier_permission_item");

            entity.Property(e => e.SupplierPermissionId).HasColumnName("supplier_permission_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.ProductionDate).HasColumnName("production_date");

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierPermissionItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__supplier___item___72C60C4A");

            entity.HasOne(d => d.SupplierPermission).WithMany(p => p.SupplierPermissionItems)
                .HasForeignKey(d => d.SupplierPermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__supplier___suppl__71D1E811");
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__transfer__3213E83F1277F390");

            entity.ToTable("transfer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FromWarehouse).HasColumnName("from_warehouse");
            entity.Property(e => e.ToWarehouse).HasColumnName("to_warehouse");

            entity.HasOne(d => d.FromWarehouseNavigation).WithMany(p => p.TransferFromWarehouseNavigations)
                .HasForeignKey(d => d.FromWarehouse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transfer__from_w__7F2BE32F");

            entity.HasOne(d => d.ToWarehouseNavigation).WithMany(p => p.TransferToWarehouseNavigations)
                .HasForeignKey(d => d.ToWarehouse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transfer__to_war__00200768");
        });

        modelBuilder.Entity<TransferItem>(entity =>
        {
            entity.HasKey(e => new { e.TransferId, e.ItemId, e.SupplierId }).HasName("PK__transfer__54A8385AB5AE761D");

            entity.ToTable("transfer_item");

            entity.Property(e => e.TransferId).HasColumnName("transfer_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.ProductionDate).HasColumnName("production_date");

            entity.HasOne(d => d.Item).WithMany(p => p.TransferItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transfer___item___03F0984C");

            entity.HasOne(d => d.Supplier).WithMany(p => p.TransferItems)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transfer___suppl__04E4BC85");

            entity.HasOne(d => d.Transfer).WithMany(p => p.TransferItems)
                .HasForeignKey(d => d.TransferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__transfer___trans__02FC7413");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__unit__3213E83FE11AF4E2");

            entity.ToTable("unit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__warehous__3213E83FB19E8F71");

            entity.ToTable("warehouse");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Manager).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__warehouse__manag__5EBF139D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
