using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraApi.Data.Dtos;

public class ReadApiDto
{
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string NomeCompleto { get; set; }

    [Required(ErrorMessage = "O cargo é obrigatório")]
    public string Cargo { get; set; }
    [Required(ErrorMessage = "O Email é obrigatório")]
    public string Email { get; set; }


}
