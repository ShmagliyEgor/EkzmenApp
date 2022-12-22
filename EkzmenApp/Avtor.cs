using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Avtor
    {
        [Key]
        public int IDАвтора { get; set; } //поле логина
        public string ФИО { get; set; } //поле логина
        public DateTime ДатаРождения { get; set; } //поле логина

    }
}
