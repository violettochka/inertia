using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;

namespace inertia.models
{
    public class Trap : GenerateClass
    {
        public Trap(int x, int y) : base(x, y)
        {
            Pixel = '?';
        }

        public void CreateTraps(int count, BaseClass[,] field)
        {
            for (int i = 0; i < count; i++)
            {
                var trap = GenerateEntity(field, (x, y) => new Trap(x, y));
                Draw(trap.X, trap.Y);
            }
        }
    }
}
