using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiplomProject.Domain
{
    public class InfoAp
    {

        [Required]
        public int ID { get; set; }

        [Display(Name = " Адресс ")]
        public string Adress { get; set; }
        
        [Display(Name = "Информация об услуге")]
        public string Info { get; set; }

        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
    }
}
