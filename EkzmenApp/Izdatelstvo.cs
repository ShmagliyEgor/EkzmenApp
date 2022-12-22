using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Izdatelstvo
    {
        [Key]
        public int IDИздательство { get; set; } //поле логина
        public string Наименование { get; set; } //поле логина
        public string Адрес { get; set; } //поле логина
        public string Телефон { get; set; } //поле логина
    }
}
