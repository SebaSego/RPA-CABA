using System;
using System.Collections.Generic;

namespace RPA.Domain.Entities;

public partial class Genero
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PersonaFisica> PersonasFisicas { get; } = new List<PersonaFisica>();
}
