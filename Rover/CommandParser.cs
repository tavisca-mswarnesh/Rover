using System;

namespace Rover
{
    public class CommandParser
    {
        public Position Parse(Position position,string command)
        {
            int commandLength = command.Length;
            command=command.ToUpper();
            Turn turn = new Turn();
            Move move = new Move();
            Enum.TryParse(position.Direction.ToString(), out Direction direction);
            for (int i=0;i< commandLength; i++)
            {
                if (command[i] == 'L')
                {
                    direction=turn.Left(direction);
                }
                else if (command[i] == 'R')
                {
                    direction = turn.Right(direction);
                }
                else if(command[i]=='M')
                {
                    position=move.Forword(position,direction);
                }
                position.Direction = direction.ToString();
                    
            }
            return position;

        }
    }
}
