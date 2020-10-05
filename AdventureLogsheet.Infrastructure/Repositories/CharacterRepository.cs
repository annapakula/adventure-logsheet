using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureLogsheet.Domain.Interface;
using AdventureLogsheet.Domain.Model;

namespace AdventureLogsheet.Infrastructure.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly Context _context;

        public CharacterRepository(Context context)
        {
            _context = context;
        }

        public int AddCharacter(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return character.Id;
        }
        public void DeleteCharacter(int characterId)
        {
            var character = _context.Characters.Find(characterId);
            if (character != null)
            {
                _context.Characters.Remove(character);
                _context.SaveChanges();
            }
        }
        public Character GetCharacterById(int characterId)
        {
            var character = _context.Characters.FirstOrDefault(i => i.Id == characterId);
            return character;
        }

        public IQueryable<Character> GetAllCharacters()
        {
            var characters = _context.Characters;
            return characters;
        }
    }
}
