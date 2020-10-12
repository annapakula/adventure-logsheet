using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class TreasureCheckpoints
    {
        public int Id { get; set; }
        public int StartingTCP { get; set; }
        public int EarnedTCP { get; set; }
        public int TotalTCP { get; set; }
        public int Tier { get; set; }
        public int AdventureRef { get; set; }
        public Adventure Adventure { get; set; }
    }
}
