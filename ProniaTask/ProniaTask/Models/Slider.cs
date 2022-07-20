using Microsoft.AspNetCore.Http;
using ProniaTask.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Models
{
    public class Slider:BaseEntity
    {
        public string Image { get; set; }
        [Required(ErrorMessage ="Ok")]
        public string Discount { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public byte Order { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }        
    }
}
