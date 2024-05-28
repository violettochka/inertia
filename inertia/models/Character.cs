using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inertia.base_elems;
using inertia.enums;

namespace inertia.models
{
    public class Character : BaseClass
    {
        public Character(int x, int y) : base(x, y)
        {
            Pixel = '$'; 
        }
        public Direction Direction { get; set; }
        private Dictionary<Direction, (int, int)> _direction = new Dictionary<Direction, (int, int)>
        {
            { Direction.Right,        ( 1,  0) },
            { Direction.Left,         (-1,  0) },
            { Direction.Down,         ( 0,  1) },
            { Direction.Up,           ( 0, -1) },
            { Direction.RigthUp,      ( 1, -1) },
            { Direction.LeftUp,       (-1, -1) },
            { Direction.RigthDown,    ( 1,  1) },
            { Direction.LeftDown,     (-1,  1) },
        };

        public (int, int) ChangeDirection(Direction direction, BaseClass elem, BaseClass[,] field)
        {
            if (_direction.TryGetValue(direction, out var coordinates))
            {
                Clear(X, Y);
                int newX = X + coordinates.Item1;
                int newY = Y + coordinates.Item2;

                return (newX, newY);
            }

            return (elem.X, elem.Y);
        }

        public void RewriteEntity(BaseClass[,] field, int x, int y, BaseClass elem)
        {
            field[elem.X, elem.Y] = new BaseClass(elem.X, elem.Y);
            elem.X = x;
            elem.Y = y;
            field[x, y] = elem;
        }

        public void Move(Direction direction, BaseClass[,] field)
        {
            Clear(X, Y);
            Direction = direction;
            var newCoordinates = ChangeDirection(direction, this, field);
            RewriteEntity(field, newCoordinates.Item1, newCoordinates.Item2, this);
            Draw(X, Y);
        }

        public override bool IsContainGameElem()
        {
            return true;
        }
    }
}
