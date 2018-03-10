using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Translator.WebUI.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        [Required]
        [Display(Name = "Choose language")]
        public string SourseLng { get; set; }

        [Required]
        [Display(Name = "For translate")]
        public string SoursePhrase { get; set; }

        [Required]
        [Display(Name = "Choose language")]
        public string DestLng { get; set; }


        [Display(Name = "Result")]
        public string DestPhrase { get; set; }
    }
}
