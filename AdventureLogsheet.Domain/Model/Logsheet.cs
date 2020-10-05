using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureLogsheet.Domain.Model
{
    public class Logsheet
    {
        public int Id { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
        //public virtual ICollection<Adventure> Adventures { get; set; }
    }
}
