using System.ComponentModel.DataAnnotations;

namespace Curso.Prueba.Application;

public class BookCRUDDto
{
    [Required]
    public string? Titulo {get; set;}

    [Required]
    public int AutorId {get; set;}
    
    [Required]
    public long Paginas {get; set;}
    
    [Required]
    public DateTime Fecha {get; set;}
}
