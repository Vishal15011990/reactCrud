using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace reactCrud.Models
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CityInfo> CityInfo { get; set; }
        public virtual DbSet<CountryInfo> CountryInfo { get; set; }
        public virtual DbSet<EmpInfo> EmpInfo { get; set; }
        public virtual DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public virtual DbSet<FileUpload> FileUpload { get; set; }
        public virtual DbSet<MasterAdmin> MasterAdmin { get; set; }
        public virtual DbSet<PhoneMaster> PhoneMaster { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<QualificationMaster> QualificationMaster { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<StateInfo> StateInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BUE1523; initial Catalog=Employee;integrated security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityInfo>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("City_Info");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.CityName).HasColumnName("City_Name");

                entity.Property(e => e.StateRefId).HasColumnName("State_RefId");

                entity.HasOne(d => d.StateRef)
                    .WithMany(p => p.CityInfo)
                    .HasForeignKey(d => d.StateRefId)
                    .HasConstraintName("FK_City_Info_State_Info");
            });

            modelBuilder.Entity<CountryInfo>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_Country");

                entity.ToTable("Country_Info");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.CountryName).HasColumnName("Country_name");
            });

            modelBuilder.Entity<EmpInfo>(entity =>
            {
                entity.ToTable("Emp_Info");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpAddress)
                    .IsRequired()
                    .HasColumnName("Emp_Address");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.EmpInfo)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_Emp_City_City_Info");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.EmpInfo)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_Emp_Country_Country_Info");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.EmpInfo)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_Emp_State_State_Info");
            });

            modelBuilder.Entity<EmployeeMaster>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Employee_Master");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Createdon).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ModiefiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.EmployeeMaster)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_Employee_Master_City");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.EmployeeMaster)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_Employee_Master_Country");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmployeeMaster)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Employee___RoleI__17036CC0");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.EmployeeMaster)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_Employee_Master_State");
            });

            modelBuilder.Entity<FileUpload>(entity =>
            {
                entity.HasKey(e => e.UploadId);

                entity.Property(e => e.UploadId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("File_name");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("File_path");

                entity.Property(e => e.FileSize)
                    .IsRequired()
                    .HasColumnName("File_size");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("File_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterAdmin>(entity =>
            {
                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AdminPassword).IsRequired();
            });

            modelBuilder.Entity<PhoneMaster>(entity =>
            {
                entity.ToTable("Phone_Master");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone_Number")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.Property(e => e.EmRefId).HasColumnName("EmRefID");

                entity.Property(e => e.QualRefId).HasColumnName("QualRefID");

                entity.HasOne(d => d.EmRef)
                    .WithMany(p => p.Qualification)
                    .HasForeignKey(d => d.EmRefId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Qualification_Employee");

                entity.HasOne(d => d.QualRef)
                    .WithMany(p => p.QualificationNavigation)
                    .HasForeignKey(d => d.QualRefId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Qualification_Qualification_Master");
            });

            modelBuilder.Entity<QualificationMaster>(entity =>
            {
                entity.ToTable("Qualification_Master");
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.Createdon).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.RoleName).IsRequired();
            });

            modelBuilder.Entity<StateInfo>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("State_info");

                entity.Property(e => e.StateId).HasColumnName("State_Id");

                entity.Property(e => e.CountryRefId).HasColumnName("Country_RefId");

                entity.Property(e => e.StateName).HasColumnName("State_Name");

                entity.HasOne(d => d.CountryRef)
                    .WithMany(p => p.StateInfo)
                    .HasForeignKey(d => d.CountryRefId)
                    .HasConstraintName("FK_State_info_Country_Info");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
