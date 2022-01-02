using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project.Models
{
    public partial class DataBasePhatTrienWebContext : DbContext
    {
        public DataBasePhatTrienWebContext()
        {
        }

        public DataBasePhatTrienWebContext(DbContextOptions<DataBasePhatTrienWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catergory> Catergories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;user=root;password=hoangvan;database=DataBasePhatTrienWeb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catergory>(entity =>
            {
                entity.ToTable("Catergory", "DataBasePhatTrienWeb");

                entity.Property(e => e.CatergoryId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Catergory_ID");

                entity.Property(e => e.CatergoryDescription)
                    .HasMaxLength(100)
                    .HasColumnName("Catergory_Description");

                entity.Property(e => e.CatergoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Catergory_Name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "DataBasePhatTrienWeb");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(10)
                    .HasColumnName("Customer_Phone")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order", "DataBasePhatTrienWeb");

                entity.HasIndex(e => e.CustomerId, "FK_Customer_ID");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Order_ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("Order_Date");

                entity.Property(e => e.OrderShipAddress)
                    .HasMaxLength(200)
                    .HasColumnName("Order_ShipAddress")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderShipPhone)
                    .HasMaxLength(10)
                    .HasColumnName("Order_ShipPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.OrderShipName)
                    .HasMaxLength(200)
                    .HasColumnName("Order_ShipName")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderShipEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Order_ShipEmail")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasColumnName("Order_Status");

                entity.Property(e => e.OrderTotal)
                    .HasMaxLength(200)
                    .HasColumnName("Order_Total");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_ID");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId)
                    .HasName("PRIMARY");

                entity.ToTable("OrderDetails", "DataBasePhatTrienWeb");

                entity.HasIndex(e => e.OrderId, "FK_Order_ID");

                entity.HasIndex(e => e.ProductId, "FK_Product_ID");

                entity.Property(e => e.OrderDetailsId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("OrderDetails_ID");

                entity.Property(e => e.OrderDetailsPrice).HasColumnName("OrderDetails_Price");

                entity.Property(e => e.OrderDetailsQuantity).HasColumnName("OrderDetails_Quantity");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Order_ID");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Product_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "DataBasePhatTrienWeb");

                entity.HasIndex(e => e.CatergoryId, "FK_Catergory_ID");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Product_ID");

                entity.Property(e => e.CatergoryId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("Catergory_ID");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(100)
                    .HasColumnName("Product_Description");

                entity.Property(e => e.ProductImageUrl).HasColumnName("Product_ImageURl");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");

                entity.Property(e => e.ProductPromotionPrice).HasColumnName("Product_PromotionPrice");

                entity.Property(e => e.ProductQuantity).HasColumnName("Product_Quantity");

                entity.HasOne(d => d.Catergory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatergoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Catergory_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
