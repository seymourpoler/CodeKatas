using System;

namespace MarsRover
{
	public class BackwardCommand : ICommand
	{
		private IEngine _rightMotor;
		private IEngine _leftMotor;

		public BackwardCommand(IEngine rigthMotor, IEngine leftMotor)
		{
			_rightMotor = rigthMotor;
			_leftMotor = leftMotor;
		}

		public void Execute(int seconds)
		{
			_rightMotor.Backward (seconds);
			_leftMotor.Backward (seconds);
		}
	}
}

