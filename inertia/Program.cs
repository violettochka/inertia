using inertia.base_elems;
using inertia.console;
using inertia.enums;
using inertia.models;

namespace inertia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayingField playingField = new PlayingField();
            BaseClass[,] field = playingField.Generatefield(SettingsForConsole.WIDTH, 
                                                            SettingsForConsole.HEIGTH);

            Character character = new Character(3, 3);
            field[character.X, character.Y] = character;
            ConsoleForUser user = new ConsoleForUser();

            new Wall(0, 0).CreateWalls(10, field);
            new Stop(0, 0).CreateStops(15, field);
            new Prize(0, 0).CreatePrizes(7, field);

            
            while (true)
            {
                Direction curDirection = user.ReadMovement(character.Direction);
                character.Move(curDirection, field);
                Thread.Sleep(100);
            }
        }
    }
}
