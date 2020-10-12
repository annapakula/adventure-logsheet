using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class Gold
    {
        public int Id { get; set; }
        public int StartingGold { get; set; }
        public int EarnedGold { get; set; }
        public int TotalGold { get; set; }
        public int AdventureRef { get; set; }
        public Adventure Adventure { get; set; }
    }
}
