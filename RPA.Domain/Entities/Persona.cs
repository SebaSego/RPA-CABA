using System;
using System.Collections.Generic;

namespace RPA.Domain.Entities;

public partial class Persona
{
    public int Id { get; set; }

    public int TipoPersonaId { get; set; }

    public int CuitCuil { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Celular1 { get; set; }

    public string? Celular2 { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public virtual ICollection<Administrador> Administradores { get; } = new List<Administrador>();

    public virtual ICollection<PersonaDomicilio> PersonasDomicilios { get; } = new List<PersonaDomicilio>();

    public virtual PersonaFisica? PersonasFisica { get; set; }

    public virtual PersonaJuridica? PersonasJuridica { get; set; }

    public virtual TipoPersona TipoPersona { get; set; } = null!;
}
