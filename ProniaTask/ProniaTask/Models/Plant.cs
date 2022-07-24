using Microsoft.AspNetCore.Http;
using ProniaTask.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Models
{
    public class Plant:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        //[Column(TypeName ="decimal(6.2)")]
        //item.SetDefaultValue(20.5m);
        public string Desc { get; set; }
        public string SKU { get; set; }
        public int PlantInformationId { get; set; }        
        public string Text_Desc { get; set; }
        public PlantInformation PlantInformation { get; set; }
        public List<PlantImage> PlantImages { get; set; }
        public List<PlantCategory> PlantCategories { get; set; }
        public List<PlantTag> PlantTags { get; set; }
        [NotMapped]
        public List<int> CategoryId { get; set; }
        [NotMapped]
        public IFormFile MainPhoto { get; set; }
        [NotMapped]
        public IFormFile HoverPhoto { get; set; }
        [NotMapped]
        public List<IFormFile> Photos { get; set; }

        [NotMapped]
        public List<int> ImagesId { get; set; }
    }
}
