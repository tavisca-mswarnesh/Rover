using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.Tests
{
    public class TurnTests
    {
        Turn turn = new Turn();
        [Fact]
        public void Turn_Left_When_Direction_Is_North_Test()
        {
            var  expected= Direction.W;
            var actual = turn.Left(Direction.N);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Left_When_Direction_Is_South_Test()
        {
            var expected = Direction.E;
            var actual = turn.Left(Direction.S);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Left_When_Direction_Is_East_Test()
        {
            var expected = Direction.N;
            var actual = turn.Left(Direction.E);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Left_When_Direction_Is_West_Test()
        {
            var expected = Direction.S;
            var actual = turn.Left(Direction.W);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Right_When_Direction_Is_North_Test()
        {
            var expected = Direction.E;
            var actual = turn.Right(Direction.N);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Right_When_Direction_Is_South_Test()
        {
            var expected = Direction.W;
            var actual = turn.Right(Direction.S);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Right_When_Direction_Is_East_Test()
        {
            var expected = Direction.S;
            var actual = turn.Right(Direction.E);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Turn_Right_When_Direction_Is_West_Test()
        {
            var expected = Direction.N;
            var actual = turn.Right(Direction.W);
            Assert.Equal(expected, actual);
        }

    }
}
