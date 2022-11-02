using System.ComponentModel.DataAnnotations;

namespace Curso.Prueba.Domain;

public class Book
{
    [Required]
    public int Id {get; set;}
    [Required]
    public string? Titulo {get; set;}
    [Required]
    public int AutorId {get; set;}
    public virtual Autor? Autor {get; set;}
    [Required]
    public long Paginas {get; set;}
    [Required]
    public DateTime Fecha {get; set;}
    
}
