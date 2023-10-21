﻿using System;
using System.Collections.Generic;

namespace Mate.Speak.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string? Roles { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
