using System;

namespace MarsRover
{
	public class LeftCommand : ICommand
	{
		private IEngine _motor;

		public LeftCommand (IEngine motor)
		{
			_motor = motor;
		}

		public void Execute(int seconds)
		{
			_motor.Forward (seconds);
		}
	}
}

