using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        //public List<CharacterClass> CharacterClasses { get; set; }

        //public string Classes { get; set; }

        //public string DCINumber { get; set; }

        public virtual ICollection<CharacterClass> CharacterClasses { get; set; }
        public virtual ICollection<Adventure> Adventures { get; set; }
        public int LogsheetId { get; set; }
        public virtual Logsheet Logsheet { get; set; }

    }
}
