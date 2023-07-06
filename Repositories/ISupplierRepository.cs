using SupplierRegistration.Model;

namespace SupplierRegistration.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<SupplierModel>> GetAllSuppliersAsync();
        Task<SupplierModel> GetSupplierByIdAsync(int id);
        Task AddSupplierAsync(SupplierModel supplier);
        Task UpdateSupplierAsync(SupplierModel supplier);
        Task DeleteSupplierAsync(SupplierModel supplier);
    }
}
