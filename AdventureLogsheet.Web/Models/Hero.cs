using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Web.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Classes { get; set; }
        public int Level { get; set; }

    }
}
