using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureLogsheet.Domain.Interface;
using AdventureLogsheet.Domain.Model;

namespace AdventureLogsheet.Infrastructure.Repositories
{
    public class AdventureRepository : IAdventureRepository
    {
        private readonly Context _context;

        public AdventureRepository(Context context)
        {
            _context = context;
        }
        public int AddAdventure(Adventure adventure)
        {
            _context.Adventures.Add(adventure);
            _context.SaveChanges();
            return adventure.Id;
        }
        public void DeleteAdventure(int adventureId)
        {
            var adventure = _context.Adventures.Find(adventureId);
            if (adventure != null)
            {
                _context.Adventures.Remove(adventure);
                _context.SaveChanges();
            }
        }
        public Adventure GetAdventureById(int adventureId)
        {
            var adventure = _context.Adventures.FirstOrDefault(i => i.Id == adventureId);
            return adventure;
        }

        public IQueryable<Adventure> GetAllAdventures()
        {
            var adventures = _context.Adventures;
            return adventures;
        }
    }
}
