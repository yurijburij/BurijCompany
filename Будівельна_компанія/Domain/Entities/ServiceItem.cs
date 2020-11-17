using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Будівельна_компанія.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву послуги")]
        [Display(Name = "Назва послуги")]
        public override string Title { get; set; }

        [Display(Name = "Коротке описання послуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "Повне описання послуги")]
        public override string Text { get; set; }
    }
}
