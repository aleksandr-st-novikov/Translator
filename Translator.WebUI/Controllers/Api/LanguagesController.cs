using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Translator.WebUI.Models.AdminViewModel;
using Translator.WebUI.Models.Entities.Abstract;
using Translator.WebUI.Models.Entities.Entity;

namespace Translator.WebUI.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Languages")]
    public class LanguagesController : Controller
    {
        ILanguageRepository _languageRepo;

        public LanguagesController(
            ILanguageRepository languageRepo
            )
        {
            _languageRepo = languageRepo;
        }

        // GET: api/Languages
        [HttpGet]
        public async Task<IEnumerable<Language>> Get()
        {
            //LanguageFilter filter = GetFilter();
            return await _languageRepo.GetAllAsync();
        }

        private LanguageFilter GetFilter()
        {
            NameValueCollection filter = HttpUtility.ParseQueryString(Request.Path);

            return new LanguageFilter
            {
                Code = filter["Code"],
                Title = filter["Title"]
            };
        }

        // GET: api/Languages/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Languages
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Languages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
