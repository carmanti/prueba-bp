
using System.ComponentModel.DataAnnotations;
using Curso.Prueba.Domain;

namespace Curso.Prueba.Application;
public class AutorCRUDDto
{
    [Required]
    public string? Nombre {get; set;}
}