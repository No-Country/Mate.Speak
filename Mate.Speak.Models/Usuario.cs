using System;
using System.Collections.Generic;

namespace Mate.Speak.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdRol { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string Correo { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Token { get; set; }

    public string Activo { get; set; } = null!;

    public string? Usuario1 { get; set; }

    public virtual ICollection<Dato> Datos { get; set; } = new List<Dato>();

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual Role IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Participante> Participantes { get; set; } = new List<Participante>();

    public virtual ICollection<Sala> Salas { get; set; } = new List<Sala>();
}
