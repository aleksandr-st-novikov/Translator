using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Translator.WebUI.Models;
using Translator.WebUI.Models.Entities.Abstract;
using Translator.WebUI.Models.Entities.Entity;
using Translator.WebUI.Models.HomeViewModels;
using YandexTranslateCSharpSdk;

namespace Translator.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILanguageRepository _repoLanguage;

        public HomeController(
            ILanguageRepository repoLanguage
            )
        {
            _repoLanguage = repoLanguage;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Languages = await _repoLanguage.GetAllAsync();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<ActionResult> TranslateYandex(HomeIndexViewModel model)
        {
            YandexTranslateSdk wrapper = new YandexTranslateSdk();
            wrapper.ApiKey = "trnsl.1.1.20180301T144418Z.3432b63aad346fb1.472f0a88a08f8da285f3ea90664bf07bda0878f7";
            string englishText = model.SoursePhrase;
            string translatedText = await wrapper.TranslateText(englishText, $"{model.SourseLng}-{model.DestLng}");
            return Ok(translatedText);
        }
    }
}
