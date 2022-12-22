using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Otchet
    {
        [Key]
        public int IDОтчета { get; set; } //поле логина
        public int IDПродажи { get; set; } //поле логина
        public DateTime ДатаОтчета { get; set; } //поле логина
        public decimal ИтогЗаМесяц { get; set; } //поле логина
        public string НомерОтчета { get; set; } //поле логина
    }
}
