using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator.WebUI.Data;
using Translator.WebUI.Models.Entities.Abstract;
using Translator.WebUI.Models.Entities.Entity;

namespace Translator.WebUI.Models.Entities.Concrete
{
    public class EFLanguageRepository : EFAbstractRepository<Language>, ILanguageRepository
    {
        private readonly ApplicationDbContext _context;
        public EFLanguageRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Language> FindByCodeAsync(string code)
        {
            return await _context.Languages.FirstOrDefaultAsync(l => l.Code.Equals(code,StringComparison.OrdinalIgnoreCase));
        }
    }
}
