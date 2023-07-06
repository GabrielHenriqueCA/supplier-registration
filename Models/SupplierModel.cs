using System.ComponentModel.DataAnnotations;

namespace SupplierRegistration.Model;

public class SupplierModel
{
 
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage ="Enter name valid")]
    [StringLength(100)]
    public string Name { get; set; }

    [Required(ErrorMessage ="Enter cnpj valid")]
    [RegularExpression(@"^[0-9]{14}$")]
    public string Cnpj { get; set; }

    public enum Specialty
    {
        Commerce,
        Service,
        Industry
    }

    public Specialty SpecialtySupplier { get; set; }

    [Required(ErrorMessage ="Enter cep valid")]
    [RegularExpression(@"^[0-9]{8}$")]
    public string Cep { get; set; }

    [Required(ErrorMessage ="Enter Address valid")]
    [StringLength(255)]
    public string Address { get; set; }
}