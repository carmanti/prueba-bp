using System.ComponentModel.DataAnnotations;
namespace Curso.Prueba.Domain;

public class Autor
{
    [Required]
    public int Id {get; set;}

    [Required]
    public string? Nombre {get; set;}
    
}


