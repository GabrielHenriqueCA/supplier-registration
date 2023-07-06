using Microsoft.AspNetCore.Mvc;
using SupplierRegistration.Model;
using SupplierRegistration.Repositories;

namespace Supplier_Registration.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public IActionResult Index()
        {
            var supplierList = _supplierRepository.GetAllSuppliersAsync().Result;
            return View(supplierList);
        }


        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Update(int id)
        {   
            var supplier = await _supplierRepository.GetSupplierByIdAsync(id);

            if (supplier == null)
                return NotFound();

            return View(supplier);
        }

        public async Task<IActionResult> DeleteConfirmationAsync(int id)
        {
            var supplier = await _supplierRepository.GetSupplierByIdAsync(id);

            if (supplier == null)
                return NotFound();

            return View(supplier);
        }

 
        [HttpPost]
        public async Task<IActionResult> AddSupplier(SupplierModel supplier)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _supplierRepository.AddSupplierAsync(supplier);
                    TempData["MessageSuccessyfull"] = "Supplier created successyfull";
                    return RedirectToAction("Index");
                }
                    return View("Create",supplier);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Ops, Supplier not created: {error.Message}";
                return RedirectToAction("Index");
            }
        
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSupplier(SupplierModel supplier)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existingSupplierTask = _supplierRepository.GetSupplierByIdAsync(supplier.Id);
                    var existingSupplier = await existingSupplierTask;

                    if (existingSupplier == null)
                        return RedirectToAction("Error");

                    await _supplierRepository.UpdateSupplierAsync(supplier);
                    return RedirectToAction("Index");
                }

                    return View("Update", supplier);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Ops, Supplier not updated: {error.Message}";
                return RedirectToAction("Index");
            } 
        }

        public async Task<IActionResult> DeleteSupplier(int id)
        {
            if (id == null)
                return RedirectToAction("Error");

            var existingSupplier = await _supplierRepository.GetSupplierByIdAsync(id);

            if (existingSupplier == null)
                return RedirectToAction("Error");

            await _supplierRepository.DeleteSupplierAsync(existingSupplier);
            return RedirectToAction("Index");
        }
    }
}
