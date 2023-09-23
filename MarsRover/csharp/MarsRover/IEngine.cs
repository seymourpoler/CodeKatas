using System;

namespace MarsRover
{
	public interface IEngine
	{
		void Forward(int seconds);
		void Backward(int seconds);
	}
}
