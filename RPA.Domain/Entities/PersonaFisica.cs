using System;
using System.Collections.Generic;

namespace RPA.Domain.Entities;

public partial class PersonaFisica
{
    public int Id { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int TipoDocumentoId { get; set; }

    public int NumeroDocumento { get; set; }

    public int GeneroId { get; set; }

    public virtual Genero Genero { get; set; } = null!;

    public virtual Persona IdNavigation { get; set; } = null!;

    public virtual TipoDocumento TipoDocumento { get; set; } = null!;
}
