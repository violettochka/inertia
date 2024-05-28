using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.console;

namespace inertia.base_elems
{
    public class GenerateClass : BaseClass
    {
        public Random random;
        public GenerateClass(int x, int y) : base(x, y)
        {
            random = new Random();
        }

        public delegate T CreateEntity<T>(int x, int y) where T : BaseClass;
        public T GenerateEntity<T>(BaseClass[,] field, CreateEntity<T> createMethod) where T : BaseClass
        {
            int randomX;
            int randomY;
            do
            {
                randomX = random.Next(1, SettingsForConsole.WIDTH - 1);
                randomY = random.Next(1, SettingsForConsole.HEIGTH - 1);
            } while (field[randomX, randomY].IsContainGameElem());
            var entity = createMethod(randomX, randomY);
            field[randomX, randomY] = createMethod(randomX, randomY);
            return entity;
        }
    }
}
