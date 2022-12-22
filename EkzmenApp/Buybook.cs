using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Buybook
    {
        [Key]
        public int IDПродажи { get; set; } //поле логина
        public int IDКнига { get; set; } //поле логина
    }
}
