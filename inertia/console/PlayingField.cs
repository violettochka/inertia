using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;
using inertia.models;
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

        public void GenerateBorders(BaseClass[,] field)
        {
            for (int x = 0; x < field.GetLength(0); x++)
            {
                field[x, 0] = new Wall(x, 0);
                field[x, 0].Draw(x, 0);

                field[x, SettingsForConsole.HEIGTH - 1] = new Wall(x, SettingsForConsole.HEIGTH - 1);
                field[x, SettingsForConsole.HEIGTH - 1].Draw(x, SettingsForConsole.HEIGTH - 1);
            }

            for (int y = 0; y < field.GetLength(1); y++)
            {
                field[0, y] = new Wall(0, y);
                field[0, y].Draw(0, y);

                field[SettingsForConsole.WIDTH - 1, y] = new Wall(SettingsForConsole.WIDTH - 1, y);
                field[SettingsForConsole.WIDTH - 1, y].Draw(SettingsForConsole.WIDTH - 1, y);
            }
        }


    }
}
