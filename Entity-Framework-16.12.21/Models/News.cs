using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_16._12._21.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string ImgTitle { get; set; }

        public string Img { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string JournalistName { get; set; }
    }
}
