using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Book
    {
        [Key]
        public int IDКниги { get; set; }
        public int IDИздательства { get; set; } //поле логина
        public int IDЖанра { get; set; } //поле логина
        public int IDСтеллажа { get; set; } //поле логина
        public string Наименование { get; set; } //поле логина
        public int Артикул { get; set; } //поле логина
        public string ВозрастныеОграничения { get; set; } //поле логина
        public string КоличествоСтраниц { get; set; } //поле логина
        public decimal Цена { get; set; } //поле логина
        public string Описание { get; set; } //поле логина
        public string ОбложкаКниги { get; set; } //поле логина

    }
}
