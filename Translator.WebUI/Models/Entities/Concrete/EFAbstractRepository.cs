using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator.WebUI.Data;

namespace Translator.WebUI.Models.Entities.Concrete
{
    public abstract class EFAbstractRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public EFAbstractRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<T> AddOrUpdateAsync(T updated, int id)
        {
            if (updated == null) return null;

            T res;
            T existing = await _context.Set<T>().FindAsync(id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                await _context.SaveChangesAsync();
                res = existing;
            }
            else
            {
                _context.Set<T>().Add(updated);
                await _context.SaveChangesAsync();
                res = updated;
            }
            return res;
        }

        public T AddOrUpdate(T updated, int id)
        {
            if (updated == null) return null;

            T res;
            T existing = _context.Set<T>().Find(id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                _context.SaveChanges();
                res = existing;
            }
            else
            {
                _context.Set<T>().Add(updated);
                _context.SaveChanges();
                res = updated;
            }
            return res;
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
