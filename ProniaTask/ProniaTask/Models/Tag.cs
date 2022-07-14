using ProniaTask.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<PlantTag> PlantTags { get; set; }
    }
}
