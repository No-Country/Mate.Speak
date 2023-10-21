using System;
using System.Collections.Generic;

namespace Mate.Speak.Models;

public partial class Nivele
{
    public int IdNivel { get; set; }

    public string? Nivel { get; set; }

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();
}
