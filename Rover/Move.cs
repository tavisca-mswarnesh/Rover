using System;

namespace Rover
{
    public class Move
    {
        public Position Forword(Position position,Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    position.Y++;
                    break;
                case Direction.W:
                    position.X--;
                    break;
                case Direction.S:
                    position.Y--;
                    break;
                case Direction.E:
                    position.X++;
                    break;
                default:
                    break;
            }
            return position;
        }
    }
}
