using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureLogsheet.Domain.Model;

namespace AdventureLogsheet.Domain.Interface
{
    public interface IAdventureRepository
    {
        int AddAdventure(Adventure adventure);
        void DeleteAdventure(int adventureId);
        Adventure GetAdventureById(int adventureId);
        IQueryable<Adventure> GetAllAdventures();
    }
}
