using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class Renown
    {
        public int Id { get; set; }
        public int StartingRenown { get; set; }
        public int EarnedRenown { get; set; }
        public int TotalRenown { get; set; }
        public int AdventureRef { get; set; }
        public Adventure Adventure { get; set; }
    }
}
