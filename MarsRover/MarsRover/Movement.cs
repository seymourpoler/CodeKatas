using System;

namespace MarsRover
{
	public class Movement
	{
		public string Command{get; set;}
		public int Seconds{get;set;}

		public Movement ()
		{
			Command = string.Empty;
			Seconds = 0;
		}
	}
}

