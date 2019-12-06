using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.Tests
{
    public class CommandParserTests
    {
        Move move = new Move();
        Position position = new Position();
        public bool IsEquivalent(Position expected, Position actual)
        {
            if (expected.X == actual.X && expected.Y == actual.Y && expected.Direction == actual.Direction)
            {
                return true;

            }
            return false;
        }
        CommandParser commandParser = new CommandParser();
        [Fact]
        public void Multiple_Left_Rotations_Test_1()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "LL";
            var actual = new Position { X = 0, Y = 0, Direction = "S" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Left_Rotations_Test_2()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "LLL";
            var actual = new Position { X = 0, Y = 0, Direction = "E" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Left_Rotations_Test_3()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "LLLL";
            var actual = new Position { X = 0, Y = 0, Direction = "N" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Right_Rotations_Test_1()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "RR";
            var actual = new Position { X = 0, Y = 0, Direction = "S" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Right_Rotations_Test_2()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "RRR";
            var actual = new Position { X = 0, Y = 0, Direction = "W" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Right_Rotations_Test_3()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "RRRR";
            var actual = new Position { X = 0, Y = 0, Direction = "N" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Left_Right_Rotations_Test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "LR";
            var actual = new Position { X = 0, Y = 0, Direction = "N" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multiple_Right_Left_Rotations_Test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "RL";
            var actual = new Position { X = 0, Y = 0, Direction = "N" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Turn_Left_Move_Forward_test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "LM";
            var actual = new Position { X = -1, Y = 0, Direction = "W" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Turn_Right_Move_Forward_test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "RM";
            var actual = new Position { X = 1, Y = 0, Direction = "E" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Move_Forward_Turn_Left_test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "ML";
            var actual = new Position { X = 0, Y = 1, Direction = "W" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Move_Forward_Turn_Right_test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "MR";
            var actual = new Position { X = 0, Y = 1, Direction = "E" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multi_Command_Test_1()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "MMM";
            var actual = new Position { X = 0, Y = 3, Direction = "N" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multi_Command_Test_2()
        {
            position.X = 0;
            position.Y = 1;
            position.Direction = "E";
            string command = "MML";
            var actual = new Position { X = 2, Y = 1, Direction = "N" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multi_Command_Test_3()
        {
            position.X = 10;
            position.Y = 5;
            position.Direction = "N";
            string command = "MMLMRMML";
            var actual = new Position { X = 9, Y = 9, Direction = "W" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multi_Command_Test_4()
        {
            position.X = -1;
            position.Y = -1;
            position.Direction = "S";
            string command = "LMRMMRM";
            var actual = new Position { X = -1, Y = -3, Direction = "W" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Multi_Command_Test_5()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            string command = "MMRMRMRMMLMLM";
            var actual = new Position { X = 0, Y = 0, Direction = "E" };
            var expected = commandParser.Parse(position, command);
            Assert.True(IsEquivalent(expected, actual));
        }

    }
}
