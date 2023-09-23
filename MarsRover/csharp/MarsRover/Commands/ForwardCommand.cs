using System;

namespace MarsRover
{
	public class ForwardCommand : ICommand
	{
		private IEngine _rightMotor;
		private IEngine _leftMotor;

		public ForwardCommand (IEngine rightMotor, IEngine leftMotor)
		{
			_rightMotor = rightMotor;
			_leftMotor = leftMotor;
		}

		public void Execute(int seconds)
		{
			_leftMotor.Forward (seconds);
			_rightMotor.Forward (seconds);
		}
	}
}

