using System;

namespace MarsRover
{
	public interface ICommand
	{
		void Execute (int seconds);
	}
}

