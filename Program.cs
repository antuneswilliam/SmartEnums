using System;
using System.Collections.Generic;

namespace SmartEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = new List<DndClass>();

            characters.Add(DndClass.Barbarian);
            characters.Add(DndClass.Bard);
            characters.Add(DndClass.Cleric);
            characters.Add(DndClass.Druid);
            characters.Add(DndClass.Fighter);
            characters.Add(DndClass.Monk);
            characters.Add(DndClass.Paladin);
            characters.Add(DndClass.Ranger);
            characters.Add(DndClass.Rogue);
            characters.Add(DndClass.Sorcerer);
            characters.Add(DndClass.Warlock);
            characters.Add(DndClass.Wizard);

            System.Console.WriteLine("A malignity of Goblins attacks the party! The battle starts:\n");

            foreach (var character in characters)
                System.Console.WriteLine($"{character.Value}. {character.Name} {character.Action}");

            System.Console.WriteLine("\nThe battle has ended... Victory!");

        }
    }
}
