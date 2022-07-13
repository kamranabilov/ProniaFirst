using ProniaTask.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Models
{
    public class PlantInformation:BaseEntity
    {
        public string Shipping { get; set; }
        public string AboutReternRequest { get; set; }
        public string Guarantee { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
