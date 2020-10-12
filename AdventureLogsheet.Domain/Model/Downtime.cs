using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Domain.Model
{
    public class Downtime
    {
        public int Id { get; set; }
        public int StartingDowntime { get; set; }
        public int EarnedDowntime { get; set; }
        public int TotalDowntime { get; set; }
        public int AdventureRef { get; set; }
        public Adventure Adventure { get; set; }
    }
}
