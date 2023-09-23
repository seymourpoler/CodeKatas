using System;

namespace MarsRover
{
	public class Movement
	{
		public ICommand Command{get; set;}
		public int Seconds{get;set;}

		public Movement ()
		{
			Seconds = 0;
		}

		public void Move()
		{
			Command.Execute(Seconds);
		}
	}
}

