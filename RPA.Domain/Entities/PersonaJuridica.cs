using System;
using System.Collections.Generic;

namespace RPA.Domain.Entities;

public partial class PersonaJuridica
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public virtual Persona IdNavigation { get; set; } = null!;
}
