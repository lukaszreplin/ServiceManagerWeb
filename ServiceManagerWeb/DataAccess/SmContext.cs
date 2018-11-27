using Microsoft.EntityFrameworkCore;

namespace ServiceManager.DataAccess.Model
{
  public partial class SmContext : DbContext
  {
    public SmContext()
    {
    }

    public SmContext(DbContextOptions<SmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaseDeviceStatus> BaseDeviceStatus { get; set; }
    public virtual DbSet<BaseRepairStatus> BaseRepairStatus { get; set; }
    public virtual DbSet<Clients> Clients { get; set; }
    public virtual DbSet<Devices> Devices { get; set; }
    public virtual DbSet<DeviceStatus> DeviceStatus { get; set; }
    public virtual DbSet<DeviceTypes> DeviceTypes { get; set; }
    public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
    public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
    public virtual DbSet<PermissionGroups> PermissionGroups { get; set; }
    public virtual DbSet<RepairActionDefinitions> RepairActionDefinitions { get; set; }
    public virtual DbSet<RepairActionItems> RepairActionItems { get; set; }
    public virtual DbSet<RepairActions> RepairActions { get; set; }
    public virtual DbSet<RepairComments> RepairComments { get; set; }
    public virtual DbSet<Repairs> Repairs { get; set; }
    public virtual DbSet<RepairStatus> RepairStatus { get; set; }
    public virtual DbSet<RepairTypes> RepairTypes { get; set; }
    public virtual DbSet<SettingGroups> SettingGroups { get; set; }
    public virtual DbSet<Settings> Settings { get; set; }
    public virtual DbSet<TaxRates> TaxRates { get; set; }
    public virtual DbSet<UserGroups> UserGroups { get; set; }
    public virtual DbSet<Users> Users { get; set; }
    public virtual DbSet<UserStatus> UserStatus { get; set; }
    public virtual DbSet<Voivodeships> Voivodeships { get; set; }
    public virtual DbSet<WarehouseContainers> WarehouseContainers { get; set; }
    public virtual DbSet<WarehouseContainerTypes> WarehouseContainerTypes { get; set; }
    public virtual DbSet<WarehouseItems> WarehouseItems { get; set; }
    public virtual DbSet<WarehouseItemTypes> WarehouseItemTypes { get; set; }
    public virtual DbSet<WebUsers> WebUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Testowa_v4;persist security info=True;User id=sa; Password=Discopolo@99");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Clients>(entity =>
      {
        entity.HasIndex(e => e.AnonimizedUserId)
                  .HasName("IX_AnonimizedUserId");

        entity.HasIndex(e => e.CreatedUserId)
                  .HasName("IX_CreatedUserId");

        entity.HasIndex(e => e.ExportedUserId)
                  .HasName("IX_ExportedUserId");

        entity.HasIndex(e => e.ModifiedUserId)
                  .HasName("IX_ModifiedUserId");

        entity.HasIndex(e => e.VoivodeshipId)
                  .HasName("IX_VoivodeshipId");

        entity.HasOne(d => d.AnonimizedUser)
                  .WithMany(p => p.ClientsAnonimizedUser)
                  .HasForeignKey(d => d.AnonimizedUserId)
                  .HasConstraintName("FK_dbo.Clients_dbo.Users_AnonimizedUserId");

        entity.HasOne(d => d.CreatedUser)
                  .WithMany(p => p.ClientsCreatedUser)
                  .HasForeignKey(d => d.CreatedUserId)
                  .HasConstraintName("FK_dbo.Clients_dbo.Users_CreatedUserId");

        entity.HasOne(d => d.ExportedUser)
                  .WithMany(p => p.ClientsExportedUser)
                  .HasForeignKey(d => d.ExportedUserId)
                  .HasConstraintName("FK_dbo.Clients_dbo.Users_ExportedUserId");

        entity.HasOne(d => d.ModifiedUser)
                  .WithMany(p => p.ClientsModifiedUser)
                  .HasForeignKey(d => d.ModifiedUserId)
                  .HasConstraintName("FK_dbo.Clients_dbo.Users_ModifiedUserId");

        entity.HasOne(d => d.Voivodeship)
                  .WithMany(p => p.Clients)
                  .HasForeignKey(d => d.VoivodeshipId)
                  .HasConstraintName("FK_dbo.Clients_dbo.Voivodeships_VoivodeshipId");
      });

      modelBuilder.Entity<Devices>(entity =>
      {
        entity.HasIndex(e => e.CreatedUserId)
                  .HasName("IX_CreatedUserId");

        entity.HasIndex(e => e.DeviceStatusId)
                  .HasName("IX_DeviceStatusId");

        entity.HasIndex(e => e.DeviceTypeId)
                  .HasName("IX_DeviceTypeId");

        entity.HasIndex(e => e.ModifiedUserId)
                  .HasName("IX_ModifiedUserId");

        entity.HasIndex(e => e.OwnerId)
                  .HasName("IX_OwnerId");

        entity.HasOne(d => d.CreatedUser)
                  .WithMany(p => p.DevicesCreatedUser)
                  .HasForeignKey(d => d.CreatedUserId)
                  .HasConstraintName("FK_dbo.Devices_dbo.Users_CreatedUserId");

        entity.HasOne(d => d.DeviceStatus)
                  .WithMany(p => p.Devices)
                  .HasForeignKey(d => d.DeviceStatusId)
                  .HasConstraintName("FK_dbo.Devices_dbo.DeviceStatus_DeviceStatusId");

        entity.HasOne(d => d.DeviceType)
                  .WithMany(p => p.Devices)
                  .HasForeignKey(d => d.DeviceTypeId)
                  .HasConstraintName("FK_dbo.Devices_dbo.DeviceTypes_DeviceTypeId");

        entity.HasOne(d => d.ModifiedUser)
                  .WithMany(p => p.DevicesModifiedUser)
                  .HasForeignKey(d => d.ModifiedUserId)
                  .HasConstraintName("FK_dbo.Devices_dbo.Users_ModifiedUserId");

        entity.HasOne(d => d.Owner)
                  .WithMany(p => p.Devices)
                  .HasForeignKey(d => d.OwnerId)
                  .HasConstraintName("FK_dbo.Devices_dbo.Clients_OwnerId");
      });

      modelBuilder.Entity<DeviceStatus>(entity =>
      {
        entity.HasIndex(e => e.BaseDeviceStatusId)
                  .HasName("IX_BaseDeviceStatusId");

        entity.HasOne(d => d.BaseDeviceStatus)
                  .WithMany(p => p.DeviceStatus)
                  .HasForeignKey(d => d.BaseDeviceStatusId)
                  .HasConstraintName("FK_dbo.DeviceStatus_dbo.BaseDeviceStatus_BaseDeviceStatusId");
      });

      modelBuilder.Entity<MigrationHistory>(entity =>
      {
        entity.HasKey(e => new { e.MigrationId, e.ContextKey });
      });

      modelBuilder.Entity<RepairActionDefinitions>(entity =>
      {
        entity.HasIndex(e => e.TaxRateId)
                  .HasName("IX_TaxRateId");

        entity.HasOne(d => d.TaxRate)
                  .WithMany(p => p.RepairActionDefinitions)
                  .HasForeignKey(d => d.TaxRateId)
                  .HasConstraintName("FK_dbo.RepairActionDefinitions_dbo.TaxRates_TaxRateId");
      });

      modelBuilder.Entity<RepairActionItems>(entity =>
      {
        entity.HasIndex(e => e.RepairActionId)
                  .HasName("IX_RepairActionId");

        entity.HasIndex(e => e.WarehouseItemId)
                  .HasName("IX_WarehouseItemId");

        entity.HasOne(d => d.RepairAction)
                  .WithMany(p => p.RepairActionItems)
                  .HasForeignKey(d => d.RepairActionId)
                  .HasConstraintName("FK_dbo.RepairActionItems_dbo.RepairActions_RepairActionId");

        entity.HasOne(d => d.WarehouseItem)
                  .WithMany(p => p.RepairActionItems)
                  .HasForeignKey(d => d.WarehouseItemId)
                  .HasConstraintName("FK_dbo.RepairActionItems_dbo.WarehouseItems_WarehouseItemId");
      });

      modelBuilder.Entity<RepairActions>(entity =>
      {
        entity.HasIndex(e => e.ActionUserId)
                  .HasName("IX_ActionUserId");

        entity.HasIndex(e => e.RepairActionDefinitionId)
                  .HasName("IX_RepairActionDefinitionId");

        entity.HasIndex(e => e.RepairId)
                  .HasName("IX_RepairId");

        entity.HasOne(d => d.ActionUser)
                  .WithMany(p => p.RepairActions)
                  .HasForeignKey(d => d.ActionUserId)
                  .HasConstraintName("FK_dbo.RepairActions_dbo.Users_ActionUserId");

        entity.HasOne(d => d.RepairActionDefinition)
                  .WithMany(p => p.RepairActions)
                  .HasForeignKey(d => d.RepairActionDefinitionId)
                  .HasConstraintName("FK_dbo.RepairActions_dbo.RepairActionDefinitions_RepairActionDefinitionId");

        entity.HasOne(d => d.Repair)
                  .WithMany(p => p.RepairActions)
                  .HasForeignKey(d => d.RepairId)
                  .HasConstraintName("FK_dbo.RepairActions_dbo.Repairs_RepairId");
      });

      modelBuilder.Entity<RepairComments>(entity =>
      {
        entity.HasIndex(e => e.RepairId)
                  .HasName("IX_RepairId");

        entity.HasIndex(e => e.UserId)
                  .HasName("IX_UserId");

        entity.HasOne(d => d.Repair)
                  .WithMany(p => p.RepairComments)
                  .HasForeignKey(d => d.RepairId)
                  .HasConstraintName("FK_dbo.RepairComments_dbo.Repairs_RepairId");

        entity.HasOne(d => d.User)
                  .WithMany(p => p.RepairComments)
                  .HasForeignKey(d => d.UserId)
                  .HasConstraintName("FK_dbo.RepairComments_dbo.Users_UserId");
      });

      modelBuilder.Entity<Repairs>(entity =>
      {
        entity.HasIndex(e => e.ClientId)
                  .HasName("IX_ClientId");

        entity.HasIndex(e => e.CreatedUserId)
                  .HasName("IX_CreatedUserId");

        entity.HasIndex(e => e.DeviceId)
                  .HasName("IX_DeviceId");

        entity.HasIndex(e => e.RepairStatusId)
                  .HasName("IX_RepairStatusId");

        entity.HasIndex(e => e.RepairTypeId)
                  .HasName("IX_RepairTypeId");

        entity.HasIndex(e => e.TechnicianId)
                  .HasName("IX_TechnicianId");

        entity.HasOne(d => d.Client)
                  .WithMany(p => p.Repairs)
                  .HasForeignKey(d => d.ClientId)
                  .HasConstraintName("FK_dbo.Repairs_dbo.Clients_ClientId");

        entity.HasOne(d => d.Device)
                  .WithMany(p => p.Repairs)
                  .HasForeignKey(d => d.DeviceId)
                  .HasConstraintName("FK_dbo.Repairs_dbo.Devices_DeviceId");

        entity.HasOne(d => d.RepairStatus)
                  .WithMany(p => p.Repairs)
                  .HasForeignKey(d => d.RepairStatusId)
                  .HasConstraintName("FK_dbo.Repairs_dbo.RepairStatus_ServiceStatusId");

        entity.HasOne(d => d.RepairType)
                  .WithMany(p => p.Repairs)
                  .HasForeignKey(d => d.RepairTypeId)
                  .HasConstraintName("FK_dbo.Repairs_dbo.RepairTypes_ServiceTypeId");

        entity.HasOne(d => d.Technician)
                  .WithMany(p => p.Repairs)
                  .HasForeignKey(d => d.TechnicianId)
                  .HasConstraintName("FK_dbo.Repairs_dbo.Users_TechnicianId");
      });

      modelBuilder.Entity<RepairStatus>(entity =>
      {
        entity.HasIndex(e => e.BaseRepairStatusId)
                  .HasName("IX_BaseRepairStatusId");

        entity.HasOne(d => d.BaseRepairStatus)
                  .WithMany(p => p.RepairStatus)
                  .HasForeignKey(d => d.BaseRepairStatusId)
                  .HasConstraintName("FK_dbo.RepairStatus_dbo.BaseRepairStatus_BaseRepairStatusId");
      });

      modelBuilder.Entity<RepairTypes>(entity =>
      {
        entity.Property(e => e.Id).ValueGeneratedNever();
      });

      modelBuilder.Entity<Settings>(entity =>
      {
        entity.HasIndex(e => e.SettingGroupId)
                  .HasName("IX_SettingGroupId");

        entity.HasOne(d => d.SettingGroup)
                  .WithMany(p => p.Settings)
                  .HasForeignKey(d => d.SettingGroupId)
                  .HasConstraintName("FK_dbo.Settings_dbo.SettingGroups_SettingGroupId");
      });

      modelBuilder.Entity<UserGroups>(entity =>
      {
        entity.HasIndex(e => e.PermissionGroupId)
                  .HasName("IX_PermissionGroupId");

        entity.HasOne(d => d.PermissionGroup)
                  .WithMany(p => p.UserGroups)
                  .HasForeignKey(d => d.PermissionGroupId)
                  .HasConstraintName("FK_dbo.UserGroups_dbo.PermissionGroups_PermissionGroupId");
      });

      modelBuilder.Entity<Users>(entity =>
      {
        entity.HasIndex(e => e.StatusId)
                  .HasName("IX_StatusId");

        entity.HasIndex(e => e.UserGroupId)
                  .HasName("IX_UserGroupId");

        entity.HasOne(d => d.Status)
                  .WithMany(p => p.Users)
                  .HasForeignKey(d => d.StatusId)
                  .HasConstraintName("FK_dbo.Users_dbo.UserStatus_StatusId");

        entity.HasOne(d => d.UserGroup)
                  .WithMany(p => p.Users)
                  .HasForeignKey(d => d.UserGroupId)
                  .HasConstraintName("FK_dbo.Users_dbo.UserGroups_UserGroupId");
      });

      modelBuilder.Entity<WarehouseContainers>(entity =>
      {
        entity.HasIndex(e => e.ParentId)
                  .HasName("IX_ParentId");

        entity.HasIndex(e => e.WarehouseContainerTypeId)
                  .HasName("IX_WarehouseContainerTypeId");

        entity.HasOne(d => d.Parent)
                  .WithMany(p => p.InverseParent)
                  .HasForeignKey(d => d.ParentId)
                  .HasConstraintName("FK_dbo.WarehouseContainers_dbo.WarehouseContainers_ParentId");

        entity.HasOne(d => d.WarehouseContainerType)
                  .WithMany(p => p.WarehouseContainers)
                  .HasForeignKey(d => d.WarehouseContainerTypeId)
                  .HasConstraintName("FK_dbo.WarehouseContainers_dbo.WarehouseContainerTypes_WarehouseContainerTypeId");
      });

      modelBuilder.Entity<WarehouseItems>(entity =>
      {
        entity.HasIndex(e => e.TaxRateId)
                  .HasName("IX_TaxRateId");

        entity.HasIndex(e => e.WarehouseContainerId)
                  .HasName("IX_WarehouseContainerId");

        entity.HasIndex(e => e.WarehouseItemTypeId)
                  .HasName("IX_WarehouseItemTypeId");

        entity.HasOne(d => d.TaxRate)
                  .WithMany(p => p.WarehouseItems)
                  .HasForeignKey(d => d.TaxRateId)
                  .HasConstraintName("FK_dbo.WarehouseItems_dbo.TaxRates_TaxRateId");

        entity.HasOne(d => d.WarehouseContainer)
                  .WithMany(p => p.WarehouseItems)
                  .HasForeignKey(d => d.WarehouseContainerId)
                  .HasConstraintName("FK_dbo.WarehouseItems_dbo.WarehouseContainers_WarehouseContainerId");

        entity.HasOne(d => d.WarehouseItemType)
                  .WithMany(p => p.WarehouseItems)
                  .HasForeignKey(d => d.WarehouseItemTypeId)
                  .HasConstraintName("FK_dbo.WarehouseItems_dbo.WarehouseItemTypes_WarehouseItemTypeId");
      });

      modelBuilder.Entity<WebUsers>(entity =>
      {
        entity.HasIndex(e => e.ClientId)
                  .HasName("IX_ClientId");

        entity.HasOne(d => d.Client)
                  .WithMany(p => p.WebUsers)
                  .HasForeignKey(d => d.ClientId)
                  .HasConstraintName("FK_dbo.WebUsers_dbo.Clients_ClientId");
      });
    }
  }
}
