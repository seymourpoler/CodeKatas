using System;

namespace MarsRover
{
	public class CommandFactory
	{
		private const string LEFT = "L";
		private const string RIGHT = "R";
		private const string FORWARD = "F";
		private const string BACKWARD = "B";

		private IEngine _rightMotor;
		private IEngine _leftMotor;

		public CommandFactory (IEngine rigthMotor, IEngine leftMotor)
		{
			_rightMotor = rigthMotor;
			_leftMotor = leftMotor;
		}

		public ICommand Create(string command)
		{
			switch (command.ToUpper ()) {
			case LEFT:
				return new LeftCommand (_rightMotor);
			case RIGHT:
				return new RightCommand (_leftMotor);
			case FORWARD:
				return new ForwardCommand (_rightMotor, _leftMotor);
			case BACKWARD:
				return new BackwardCommand (_rightMotor, _leftMotor);
			default:
				throw new ArithmeticException ();
			}
		}
	}
}

