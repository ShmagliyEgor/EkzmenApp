using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Buy
    {
        [Key]
        public int IDПродажи { get; set; } //поле логина
        public int КолвоПродаж { get; set; } //поле логина
        public DateTime ДатаСоставления { get; set; } //поле логина
    }
}
