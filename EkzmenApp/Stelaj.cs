using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Stelaj
    {
        [Key]
        public int IDСтеллажа { get; set; } //поле логина
        public string НазваниеСтеллажа { get; set; } //поле логина
        public int НомерПолки { get; set; } //поле логинa
        public int КолвоКниг { get; set; } //поле логинa
    }
}
