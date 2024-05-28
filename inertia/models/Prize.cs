using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;

namespace inertia.models
{
    public class Prize : GenerateClass
    {
        public Prize(int x, int y) : base(x, y)
        {
            Pixel = '*';
        }

        public void CreatePrizes(int count, BaseClass[,] field)
        {
            for (int i = 0; i < count; i++)
            {
                var prize = GenerateEntity(field, (x, y) => new Prize(x, y));
                Draw(prize.X, prize.Y);
            }
        }
    }
}
