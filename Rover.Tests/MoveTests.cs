using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.Tests
{
    public class MoveTests
    {
        Move move = new Move();
        Position position = new Position();
        
        public bool IsEquivalent(Position expected,Position actual)
        {
            if(expected.X==actual.X&&expected.Y==actual.Y&&expected.Direction==actual.Direction)
            {
                return true;

            }
            return false;
        }
        
        [Fact]
        public void Move_Forward_In_North_Test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "N";
            var actual=new Position{ X=0,Y=1,Direction="N"};
            var expected=move.Forword(position, Direction.N);
            Assert.True(IsEquivalent(expected, actual));
        }
        [Fact]
        public void Move_Forward_In_South_Test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "S";
            var actual = new Position { X = 0, Y = -1, Direction = "S" };
            var expected = move.Forword(position, Direction.S);
            Assert.True(IsEquivalent(expected, actual));

        }
        [Fact]
        public void Move_Forward_In_East_Test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "E";
            var actual = new Position { X = 1, Y = 0, Direction = "E" };
            var expected = move.Forword(position, Direction.E);
            Assert.True(IsEquivalent(expected, actual));

        }
        [Fact]
        public void Move_Forward_In_West_Test()
        {
            position.X = 0;
            position.Y = 0;
            position.Direction = "W";
            var actual = new Position { X = -1, Y = 0, Direction = "W" };
            var expected = move.Forword(position, Direction.W);
            Assert.True(IsEquivalent(expected, actual));

        }
    }
}
