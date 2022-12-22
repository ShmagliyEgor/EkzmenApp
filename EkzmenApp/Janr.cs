using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Janr
    {
        [Key]
        public int IDЖанра { get; set; } //поле логина
        public string НазваниеЖанра { get; set; } //поле логина
    }
}
