using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace iCMS.Setup.DBUpgrade.OldEF.Models.Mapping
{
    public class T_WSMap : EntityTypeConfiguration<T_WS>
    {
        public T_WSMap()
        {
            // Primary Key
            this.HasKey(t => t.WSID);

            // Properties
            this.Property(t => t.WSName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.MACADDR)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Vendor)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            this.Property(t => t.SetupTime)
                .HasMaxLength(50);

            this.Property(t => t.SetupPersonInCharge)
                .HasMaxLength(50);

            this.Property(t => t.SNCode)
                .HasMaxLength(60);

            this.Property(t => t.FirmwareVersion)
                .HasMaxLength(50);

            this.Property(t => t.AntiExplosionSerialNo)
                .HasMaxLength(50);

            this.Property(t => t.PersonInCharge)
                .HasMaxLength(50);

            this.Property(t => t.PersonInChargeTel)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_WS");
            this.Property(t => t.WSID).HasColumnName("WSID");
            this.Property(t => t.WGID).HasColumnName("WGID");
            this.Property(t => t.WSName).HasColumnName("WSName");
            this.Property(t => t.WSNO).HasColumnName("WSNO");
            this.Property(t => t.BatteryVolatage).HasColumnName("BatteryVolatage");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.MACADDR).HasColumnName("MACADDR");
            this.Property(t => t.SensorType).HasColumnName("SensorType");
            this.Property(t => t.LinkStatus).HasColumnName("LinkStatus");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
            this.Property(t => t.Vendor).HasColumnName("Vendor");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.SetupTime).HasColumnName("SetupTime");
            this.Property(t => t.SetupPersonInCharge).HasColumnName("SetupPersonInCharge");
            this.Property(t => t.SNCode).HasColumnName("SNCode");
            this.Property(t => t.FirmwareVersion).HasColumnName("FirmwareVersion");
            this.Property(t => t.AntiExplosionSerialNo).HasColumnName("AntiExplosionSerialNo");
            this.Property(t => t.RunStatus).HasColumnName("RunStatus");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.PersonInCharge).HasColumnName("PersonInCharge");
            this.Property(t => t.PersonInChargeTel).HasColumnName("PersonInChargeTel");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
