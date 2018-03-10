using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator.WebUI.Models.Entities.Abstract;

namespace Translator.WebUI.Data
{
    public class SeedData
    {
        private readonly ILanguageRepository _repoLanguage;
        public SeedData(
            ILanguageRepository repoLanguage)
        {
            _repoLanguage = repoLanguage;
        }

        public async Task Seed()
        {
            Dictionary<string, string> languages = new Dictionary<string, string>();
            languages.Add("az", "Azerbaijan");
            languages.Add("sq", "Albanian");
            languages.Add("am", "Amharic");
            languages.Add("en", "English");
            languages.Add("ar", "Arabic");
            languages.Add("hy", "Armenian");
            languages.Add("af", "Afrikaans");
            languages.Add("eu", "Basque");
            languages.Add("ba", "Bashkir");
            languages.Add("be", "Belarusian");
            languages.Add("bn", "Bengali");
            languages.Add("my", "Burmese");
            languages.Add("bg", "Bulgarian");
            languages.Add("bs", "Bosnian");
            languages.Add("cy", "Welsh");
            languages.Add("hu", "Hungarian");
            languages.Add("vi", "Vietnamese");
            languages.Add("ht", "Haitian (Creole)");
            languages.Add("gl", "Galician");
            languages.Add("nl", "Dutch");
            languages.Add("mrj", "Hill Mari");
            languages.Add("el", "Greek");
            languages.Add("ka", "Georgian");
            languages.Add("gu", "Gujarati");
            languages.Add("da", "Danish");
            languages.Add("he", "Hebrew");
            languages.Add("yi", "Yiddish");
            languages.Add("id", "Indonesian");
            languages.Add("ga", "Irish");
            languages.Add("it", "Italian");
            languages.Add("is", "Icelandic");
            languages.Add("es", "Spanish");
            languages.Add("kk", "Kazakh");
            languages.Add("kn", "Kannada");
            languages.Add("ca", "Catalan");
            languages.Add("ky", "Kyrgyz");
            languages.Add("zh", "Chinese");
            languages.Add("ko", "Korean");
            languages.Add("xh", "Xhosa");
            languages.Add("km", "Khmer");
            languages.Add("lo", "Laotian");
            languages.Add("la", "Latin");
            languages.Add("lv", "Latvian");
            languages.Add("lt", "Lithuanian");
            languages.Add("lb", "Luxembourgish");
            languages.Add("mg", "Malagasy");
            languages.Add("ms", "Malay");
            languages.Add("ja", "Japanese");
            languages.Add("jv", "Javanese");
            languages.Add("eo", "Esperanto");
            languages.Add("et", "Estonian");
            languages.Add("gd", "Scottish");
            languages.Add("sv", "Swedish");
            languages.Add("cs", "Czech");
            languages.Add("hr", "Croatian");
            languages.Add("hi", "Hindi");
            languages.Add("fr", "French");
            languages.Add("fi", "Finnish");
            languages.Add("ur", "Urdu");
            languages.Add("uk", "Ukrainian");
            languages.Add("uz", "Uzbek");
            languages.Add("udm", "Udmurt");
            languages.Add("tr", "Turkish");
            languages.Add("te", "Telugu");
            languages.Add("tt", "Tatar");
            languages.Add("ta", "Tamil");
            languages.Add("tl", "Tagalog");
            languages.Add("th", "Thai");
            languages.Add("tg", "Tajik");
            languages.Add("su", "Sundanese");
            languages.Add("sw", "Swahili");
            languages.Add("sl", "Slovenian");
            languages.Add("sk", "Slovakian");
            languages.Add("si", "Sinhala");
            languages.Add("sr", "Serbian");
            languages.Add("ceb", "Cebuano");
            languages.Add("ru", "Russian");
            languages.Add("ro", "Romanian");
            languages.Add("pt", "Portuguese");
            languages.Add("pl", "Polish");
            languages.Add("fa", "Persian");
            languages.Add("pap", "Papiamento");
            languages.Add("pa", "Punjabi");
            languages.Add("no", "Norwegian");
            languages.Add("ne", "Nepali");
            languages.Add("de", "German");
            languages.Add("mn", "Mongolian");
            languages.Add("mhr", "Mari");
            languages.Add("mr", "Marathi");
            languages.Add("mi", "Maori");
            languages.Add("mk", "Macedonian");
            languages.Add("mt", "Maltese");
            languages.Add("ml", "Malayalam");

            foreach(var lng in languages)
            {
                if(await _repoLanguage.FindByCodeAsync(lng.Key) == null)
                {
                    await _repoLanguage.AddOrUpdateAsync(new Models.Entities.Entity.Language { Code = lng.Key, Title = lng.Value }, -1);
                }
            }
        }
    }
}
