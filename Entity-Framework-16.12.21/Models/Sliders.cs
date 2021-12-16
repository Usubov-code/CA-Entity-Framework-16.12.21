using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_16._12._21.Models
{
    public class Sliders
    {

             [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Image { get; set; }
        public int Time { get; set; }
        public string Title { get; set; }

    }
}
