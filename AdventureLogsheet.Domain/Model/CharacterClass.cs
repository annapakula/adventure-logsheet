using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class CharacterClass
    {
        public int Id { get; set; }
        public string CharClass { get; set; }
        public int Level { get; set; }

        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
    }
}
