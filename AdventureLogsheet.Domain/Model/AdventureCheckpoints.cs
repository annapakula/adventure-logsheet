using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class AdventureCheckpoints
    {
        public int Id { get; set; }
        public int StartingACP { get; set; }
        public int EarnedACP { get; set; }
        public int TotalACP { get; set; }
        public int AdventureRef { get; set; }
        public Adventure Adventure { get; set; }
    }
}
