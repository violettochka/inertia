using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.enums;
using static System.Console;

namespace inertia.console
{
    public class ConsoleForUser
    {
        public Direction ReadMovement(Direction currentDirection)
        {
            if (!KeyAvailable)
            {
                return currentDirection;
            }
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            currentDirection = key switch
            {
                ConsoleKey.A => Direction.LeftUp,
                ConsoleKey.D => Direction.RigthUp,
                ConsoleKey.S => Direction.LeftDown,
                ConsoleKey.W => Direction.RigthDown,
                ConsoleKey.UpArrow => Direction.Up,
                ConsoleKey.DownArrow => Direction.Down,
                ConsoleKey.LeftArrow => Direction.Left,
                ConsoleKey.RightArrow => Direction.Right,
                _ => currentDirection
            }; 

            return currentDirection;
        }
    }
}
