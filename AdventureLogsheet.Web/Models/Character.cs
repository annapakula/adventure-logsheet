using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Web.Models
{
    public class Character
    {
        public int Id { get; set; }
        [DisplayName("Character Name")]
        public string Name { get; set; }
        public string Race { get; set; }
        public string Classes { get; set; }
        public int Level { get; set; }

    }
}
