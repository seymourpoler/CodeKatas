using Moq;
using System;
using MarsRover;
using NUnit.Framework;

namespace MarsRoverTest
{
	[TestFixture()]
	public class Test
	{
		private Mock<IEngine> _leftMotor;
		private Mock<IEngine> _rightMotor;
		Robot _robot;

		[SetUp()]
		public void SetUp ()
		{
			_leftMotor = new Mock<IEngine>();
			_rightMotor = new Mock<IEngine>();
			_robot = new Robot(_rightMotor.Object, _leftMotor.Object);
		}

		[Test()]
		public void ShouldMoveFowardOneSecond()
		{
			var movement = new string[]{"F"};

			_robot.Move(movement);

			_leftMotor.Verify(x => x.Forward(It.Is<int>(y => y == 1)));
			_rightMotor.Verify(x => x.Forward(It.Is<int>(y => y == 1)));
		}

		[Test()]
		public void ShouldMoveBackwardOneSecond()
		{
			var movement = new string[]{"B"};

			_robot.Move(movement);

			_leftMotor.Verify(x => x.Backward(It.Is<int>(y => y == 1)));
			_rightMotor.Verify(x => x.Backward(It.Is<int>(y => y == 1)));
		}


		[Test()]
		public void ShouldMoveRightOneSecond()
		{
			var movement = new string[]{"R"};

			_robot.Move(movement);
			_leftMotor.Verify(x => x.Forward(It.Is<int>(y => y == 1)));
		}

		[Test()]
		public void ShouldMoveLeftOneSecond()
		{
			var movement = new string[]{"L"};

			_robot.Move(movement);

			_rightMotor.Verify(x => x.Forward(It.Is<int>(y => y == 1)));
		}

		[Test()]
		public void ShouldMoveFordWardThreeSeconds()
		{
			var movement = new string[]{"F","F","F"};

			_robot.Move(movement);

			_leftMotor.Verify(x => x.Forward(It.Is<int>(y => y == 3)));
			_rightMotor.Verify(x => x.Forward(It.Is<int>(y => y == 3)));
		}
	}
}
