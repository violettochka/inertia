using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inertia.base_elems
{
    public class BaseClass
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public  char Pixel = ' ';
        public BaseClass(int x, int y)
        {
            X = x;
            Y = y;

        }

        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Pixel);
        }

        public virtual void Clear(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public virtual bool IsContainGameElem()
        {
            return false;
        }
    }
}
