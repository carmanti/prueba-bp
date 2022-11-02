using Curso.Prueba.Domain;

using System.ComponentModel.DataAnnotations;

namespace Curso.Prueba.Application;
public class AutorDto
{
    [Required]
    public int Id {get; set;}

    [Required]
    public string? Nombre {get; set;}
}