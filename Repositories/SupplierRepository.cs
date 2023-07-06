using Microsoft.EntityFrameworkCore;
using Supplier_Registration.Data;
using SupplierRegistration.Model;

namespace SupplierRegistration.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SupplierContext _dbContext;

        public SupplierRepository(SupplierContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<SupplierModel>> GetAllSuppliersAsync()
        {
            return await Task.Run(() => _dbContext.Suppliers.ToList());
        }

        public async Task<SupplierModel> GetSupplierByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting the vendor by ID.", ex);
            }
        }

        public async Task AddSupplierAsync(SupplierModel supplier)
        {
            await Task.Run(() =>
            {
                _dbContext.Suppliers.Add(supplier);
                _dbContext.SaveChanges();
            });
        }

        public async Task UpdateSupplierAsync(SupplierModel supplier)
        {
            var existingSupplier = await GetSupplierByIdAsync(supplier.Id);

            if (existingSupplier != null)
            {
                existingSupplier.Name = supplier.Name;
                existingSupplier.Cnpj = supplier.Cnpj;
                existingSupplier.SpecialtySupplier = supplier.SpecialtySupplier;
                existingSupplier.Cep = supplier.Cep;
                existingSupplier.Address = supplier.Address;

                _dbContext.SaveChanges();
            }
        }

        public async Task DeleteSupplierAsync(SupplierModel supplier)
        {
            _dbContext.Suppliers.Remove(supplier);
            await _dbContext.SaveChangesAsync();
        }

    }
}