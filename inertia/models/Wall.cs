using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;

namespace inertia.models
{
    public class Wall : GenerateClass
    {
        public Wall(int x, int y) : base(x, y)
        {
            Pixel = '#';
        }

        public void CreateWalls(int count, BaseClass[,] field)
        {
            for(int i = 0; i < count; i++)
            {
                var wall = GenerateEntity(field, (x, y) => new  Wall(x, y));
                Draw(wall.X, wall.Y);
            }
        }
    }
}
