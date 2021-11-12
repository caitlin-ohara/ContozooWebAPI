using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContozooWebAPI.Models
{
    public class Animals
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }
        public string ActiveHours { get; set; }
        public string Notes { get; set; }
        
    }
}
