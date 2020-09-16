using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureLogsheet.Web.Models
{
    public class Adventure
    {
        public int Id { get; set; }
        public string AdventureName { get; set; }
        public string SessionCode { get; set; }
        public DateTime Date { get; set; }
        public string DMName { get; set; }

    }
}
