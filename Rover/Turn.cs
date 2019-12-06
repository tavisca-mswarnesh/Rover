using System;

namespace Rover
{
    public class Turn
    {
        public Direction Left(Direction direction)
        {
            int temp = (int)direction;
            temp = (temp + 1) % 4;
            Enum.TryParse<Direction>(temp.ToString(), out  direction);
            return direction;
        }
        public Direction Right(Direction direction)
        {
            int temp = (int)direction;
            temp--;
            if (temp < 0)
                temp = 3;
            Enum.TryParse<Direction>(temp.ToString(), out direction);
            return direction;
        }
    }
}
