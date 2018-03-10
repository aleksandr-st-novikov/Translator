using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator.WebUI.Models.Entities.Entity;

namespace Translator.WebUI.Models.Entities.Abstract
{
    public interface ILanguageRepository
    {
        ICollection<Language> GetAll();
        Task<ICollection<Language>> GetAllAsync();
        Task<bool> SaveChangesAsync();
        bool SaveChanges();
        Task<Language> AddOrUpdateAsync(Language updated, int id);
        Language AddOrUpdate(Language updated, int id);
        Language FindById(int id);
        Task<Language> FindByIdAsync(int id);
        Task<Language> FindByCodeAsync(string code);
    }
}
