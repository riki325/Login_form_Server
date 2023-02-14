using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.repositories
{            
    public class PrivateUserDetailsRepository : IDataRepository<PrivateUserDetails>
    {
        IContext _context;
        public PrivateUserDetailsRepository(IContext context)
        {
            _context = context;
        }


        public async Task<PrivateUserDetails> AddAsync(PrivateUserDetails entity)
        {
            EntityEntry<PrivateUserDetails> newEntity = _context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task<List<PrivateUserDetails>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<PrivateUserDetails> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
