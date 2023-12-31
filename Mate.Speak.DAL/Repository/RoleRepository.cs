﻿using Mate.Speak.DAL.DataContext;
using Mate.Speak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mate.Speak.DAL.Repository
{
    public class RoleRepository : IGenericRepository<Role>
    {
        private readonly MateContext _dbcontext;

        public RoleRepository(MateContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> Actualizar(Role modelo)
        {
            _dbcontext.Roles.Update(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Role modelo = _dbcontext.Roles.First(c => c.IdRol == id);
            _dbcontext.Roles.Remove(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Role modelo)
        {
           _dbcontext.Roles.Add(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<Role> Obtener(int id)
        {
            return await _dbcontext.Roles.FindAsync(id);
        }

        public async Task<IQueryable<Role>> ObtenerTodos()
        {
            IQueryable<Role> queryRolSQL = _dbcontext.Roles;
            return queryRolSQL;
        }
    }
}
