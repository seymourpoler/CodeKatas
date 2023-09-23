using System;
using System.Collections.Generic;

namespace MarsRover
{
	public class Robot
	{
		private CommandFactory _commandFactory;

		public Robot (IEngine rightMotor, IEngine leftMotor)
		{
			_commandFactory = new CommandFactory (rightMotor, leftMotor);
		}

		public void Move (string[] movements)
		{
			var commands = CreateCommands(movements);
			ProcessCommands(commands);
		}

		private IList<Movement> CreateCommands (string[] movements)
		{
			var result = new List<Movement> ();
			var before = string.Empty;
			foreach (string command in movements) {
				if(command != before){
					result.Add(new Movement(){
						Command = _commandFactory.Create(command),
						Seconds = 1
					});
					before = command;
				}
				else{
					result[result.Count - 1].Seconds += 1;
				}
			}
			return result;
		}

		private void ProcessCommands (IList<Movement> movements)
		{
			foreach (var movement in movements) {
				movement.Move ();
			}
		}
	}
}
