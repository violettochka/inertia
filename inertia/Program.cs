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
            playingField.GenerateBorders(field);

            Character character = new Character(3, 3);
            field[character.X, character.Y] = character;
            ConsoleForUser user = new ConsoleForUser();

            new Trap(0, 0).CreateTraps(20, field);
            new Wall(0, 0).CreateWalls(25, field);
            new Stop(0, 0).CreateStops(25, field);
            new Prize(0, 0).CreatePrizes(7, field);
            Direction curDirection = Direction.None;
            while (GameConditional.IsGameContinue)
            {
                if (character.IsStopped)
                {
                   curDirection = user.ReadMovement(character.Direction);
                }
                character.Move(curDirection, field);
                Thread.Sleep(100);
            }
        }
    }
}
