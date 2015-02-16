using System;

namespace MarsRover
{
	public class RightCommand : ICommand
	{
		IEngine _motor;

		public RightCommand (IEngine motor)
		{
			_motor = motor;
		}

		public void Execute(int seconds)
		{
			_motor.Forward (seconds);
		}
	}
}
