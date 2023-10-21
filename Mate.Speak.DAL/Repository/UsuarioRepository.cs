﻿using Mate.Speak.DAL.DataContext;
using Mate.Speak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mate.Speak.DAL.Repository
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly MateContext _dbcontext;

        public UsuarioRepository(MateContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> Actualizar(Usuario modelo)
        {
           _dbcontext.Usuarios.Update(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Usuario modelo = _dbcontext.Usuarios.First(c => c.IdUsuario == id);
            _dbcontext.Usuarios.Remove(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public Task<bool> Insertar(Usuario modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Usuario>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
