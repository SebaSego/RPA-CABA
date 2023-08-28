using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPA.Web;

public partial class Consorcio
{
    public int Id { get; set; }
    
    [Display(Name = "CUIT")]
    public int Cuit { get; set; }

    [Display(Name = "Denominación")]
    public string Denominacion { get; set; } = null!;

    [Display(Name = "Fecha de Alta")]
    public DateTime FechaAlta { get; set; }
    
    [Display(Name = "Fecha de Baja")]
    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<ConsorcioAdministrador> ConsorciosAdministradores { get; } = new List<ConsorcioAdministrador>();

    public virtual ICollection<ConsorcioDomicilio> ConsorciosDomicilios { get; } = new List<ConsorcioDomicilio>();
}
