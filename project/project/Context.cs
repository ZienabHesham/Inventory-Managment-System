using project;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Context: DbContext
    {
        public Context() :base("Data Source=.;Initial Catalog=StoreDB;Integrated Security=True")
        { }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<IssueOrder> IssueOrders { get; set; }
        public virtual DbSet<IssueOrderItem> IssueOrderItems { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }
        public virtual DbSet<SupplyOrderItem> SupplyOrderItems { get; set; }
        public virtual DbSet<TransferOrderItem> TransferOrderItems { get; set; }
        public virtual DbSet<TransferOrder> TransferOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        ;

            modelBuilder.Entity<TransferOrder>()
                .HasRequired(t => t.SourceStore)
                .WithMany()
                .HasForeignKey(t => t.SourceStoreId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransferOrder>()
                .HasRequired(t => t.DestinationStore)
                .WithMany()
                .HasForeignKey(t => t.DestinationStoreId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransferOrderItem>()
                .HasRequired(t => t.TransferOrder)
                .WithMany(t => t.OrderItems)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                 .HasMany(s => s.TransferOrders)
                 .WithRequired(t => t.SourceStore)
                 .HasForeignKey(t => t.SourceStoreId)
                 .WillCascadeOnDelete(false);
        }

    


    }
}


