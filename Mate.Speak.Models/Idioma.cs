using System;
using System.Collections.Generic;

namespace Mate.Speak.Models;

public partial class Idioma
{
    public int IdIdioma { get; set; }

    public string? Idiomas { get; set; }

    public virtual ICollection<AdminSala> AdminSalas { get; set; } = new List<AdminSala>();

    public virtual ICollection<Dato> Datos { get; set; } = new List<Dato>();

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();
}
