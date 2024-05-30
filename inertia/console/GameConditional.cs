using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using inertia.models;
using static System.Formats.Asn1.AsnWriter;

namespace inertia.console
{
    public class GameConditional
    {
        public static bool IsGameContinue = true;
        public static bool IsWin = false;
        public static void EndOfTheGame(Character character)
        {
            string message = $"The game has ended. Status: {IsWin}. Score: {character.CountPrize}.";
            int windowWidth = Console.WindowWidth;
            int messageLength = message.Length;
            int padding = (windowWidth - messageLength) / 2;

            Console.Clear();
            Console.SetCursorPosition(padding, Console.WindowHeight / 2);
            Console.WriteLine(message);
        }
    }
}
