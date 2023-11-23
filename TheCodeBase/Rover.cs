using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCodeBase
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direction { get; private set; }

        public Rover(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void TurnLeft()
        {
            Direction = Direction switch
            {
                'N' => 'W',
                'W' => 'S',
                'S' => 'E',
                'E' => 'N',
                _ => Direction
            };
        }

        public void TurnRight()
        {
            Direction = Direction switch
            {
                'N' => 'E',
                'E' => 'S',
                'S' => 'W',
                'W' => 'N',
                _ => Direction
            };
        }

        public void Move()
        {
            switch (Direction)
            {
                case 'N':
                    Y += 1;
                    break;
                case 'S':
                    Y -= 1;
                    break;
                case 'E':
                    X += 1;
                    break;
                case 'W':
                    X -= 1;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }
    }

}
