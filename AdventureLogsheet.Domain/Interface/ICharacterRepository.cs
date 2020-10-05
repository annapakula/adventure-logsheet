using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureLogsheet.Domain.Model;

namespace AdventureLogsheet.Domain.Interface
{
    public interface ICharacterRepository
    {
        int AddCharacter(Character character);
        void DeleteCharacter(int characterId);
        Character GetCharacterById(int characterId);
        IQueryable<Character> GetAllCharacters();
    }
}
