using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class Adventure
    {
        public int Id { get; set; }
        public string AdventureName { get; set; }
        public string SessionCode { get; set; }
        public DateTime Date { get; set; }
        public string DMName { get; set; }
        public string AdventureNotes { get; set; }
        public string SpellComponentsPurchased { get; set; }
        public AdventureCheckpoints AdventureCheckpoints { get; set; }
        public Gold Gold { get; set; }
        public Downtime Downtime { get; set; }
        public Renown Renown { get; set; }
        public TreasureCheckpoints TreasureCheckpoints { get; set; }
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        //public virtual ICollection<AdventureCheckpoints> AdventureCheckpoints { get; set; }
        //public virtual ICollection<Gold> Gold { get; set; }
        //public virtual ICollection<Downtime> Downtime { get; set; }
        //public virtual ICollection<Renown> Renown { get; set; }
        //public virtual ICollection<TreasureCheckpoints> TreasureCheckpoints { get; set; }


    }
}
