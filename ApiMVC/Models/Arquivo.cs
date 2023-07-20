using System.ComponentModel.DataAnnotations;

namespace ApiMVC.Models;

public class Arquivo
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Caminho { get; set; }

}
