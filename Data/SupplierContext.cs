using Microsoft.EntityFrameworkCore;
using SupplierRegistration.Model;

namespace Supplier_Registration.Data
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions<SupplierContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<SupplierModel> Suppliers { get; set; }
    }
}
