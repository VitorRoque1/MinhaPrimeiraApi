using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraApi.Models;

public class Api
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required] public string Email { get; set; }
    [MaxLength] public int Telefone { get; set; }
    public string NomeCompleto { get; set; }
   
}
