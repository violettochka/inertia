using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;
using static System.Console;

namespace inertia.console
{
    public class PlayingField
    {
        public BaseClass[,] Generatefield(int wigth, int heigth)
        {
            CursorVisible = false;
            SetWindowSize(SettingsForConsole.WIDTH, SettingsForConsole.HEIGTH);
            BaseClass[,] field = new BaseClass[wigth, heigth];
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    field[x, y] = new BaseClass(x, y);
                }
            }
            return field;
        }
    }
}
