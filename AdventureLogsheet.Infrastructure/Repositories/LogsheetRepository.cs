using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureLogsheet.Domain.Model;

namespace AdventureLogsheet.Infrastructure.Repositories
{
    public class LogsheetRepository
    {
        private readonly Context _context;

        public LogsheetRepository(Context context)
        {
            _context = context;
        }

        
    }
}
