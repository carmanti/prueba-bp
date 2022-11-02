
using System.ComponentModel.DataAnnotations;

namespace Curso.Prueba.Application;

public class BookDto
{
    [Required]
    public int Id {get; set;}

    [Required]
    public string? Titulo {get; set;}

    [Required]
    public int AutorId {get; set;}
    public string? Autor {get; set;}

    [Required]
    public long Paginas {get; set;}

    [Required]
    public DateTime Fecha {get; set;}
    
}
