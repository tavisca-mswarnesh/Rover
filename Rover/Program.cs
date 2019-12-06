using System;

namespace Rover
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Do not change
            string input = Console.ReadLine();

            do
            {
                
                string[] inputPosition = input.Split(',');
                Position position = new Position();
                position.X = Int32.Parse(inputPosition[0]);
                position.Y = Int32.Parse(inputPosition[1]);
                position.Direction = inputPosition[2];
                string command = Console.ReadLine();
                CommandParser commandParser = new CommandParser();
                commandParser.Parse(position, command);
                Console.WriteLine(position.X + "," + position.Y + "," + position.Direction);
                input = Console.ReadLine();
            } while (input!="-1");
            
            #endregion
            Console.Read();
            return;
        }
    }
}
