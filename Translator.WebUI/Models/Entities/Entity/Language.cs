using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Translator.WebUI.Models.Entities.Entity
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Language")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Title { get; set; }
    }
}
