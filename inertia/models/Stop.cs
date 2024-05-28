using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;

namespace inertia.models
{
    public class Stop : GenerateClass
    {
        public Stop(int x, int y) : base(x, y)
        {
            Pixel = '.';
        }

        public void CreateStops(int count, BaseClass[,] field)
        {
            for(int i = 0; i < count; i++)
            {
                var stop = GenerateEntity(field, (x, y) => new Stop(x,y));
                Draw(stop.X, stop.Y);
            }
        }
    }
}
