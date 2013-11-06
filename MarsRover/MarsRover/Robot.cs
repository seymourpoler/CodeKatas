using System;
using System.Collections.Generic;

namespace MarsRover
{
	public class Robot
	{
		private const string LEFT = "L";
		private const string RIGHT = "R";
		private const string FORWARD = "F";
		private const string BACKWARD = "B";
		private const string LIFE = "C";

		public IEngine RightMotor{get;set;}
		public IEngine LeftMotor{get;set;}
		private Position _position;

		public Robot ()
		{
			_position = Position();

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
						Command = command,
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

		private void ProcessCommands (IList<Movement> commands)
		{
			foreach (var command in commands) {
				ProcessCommand(command);
			}
		}

		private void ProcessCommand (Movement command)
		{
			switch(command.Command)
				{
				case FORWARD:
					MoveForward(command.Seconds);
					_position.Y += command.Seconds;
					break;
				case BACKWARD:
					MoveBackWard(command.Seconds);
					_position.Y -= command.Seconds;
					break;
				case RIGHT:
					MoveRight(command.Seconds);
					_position.X += command.Seconds;
					break;
				case LEFT:
					MoveLeft(command.Seconds);
					_position.X -= command.Seconds;
					break;
				case LIFE:
					break;
				}
		}

		private void MoveLeft(int seconds)
		{
			RightMotor.Backward (seconds);
		}

		private void MoveRight(int seconds)
		{
			LeftMotor.Backward (seconds);
		}

		private void MoveForward(int seconds)
		{
			LeftMotor.Forward (seconds);
			RightMotor.Forward (seconds);
		}

		private void MoveBackWard(int seconds)
		{
			LeftMotor.Backward (seconds);
			RightMotor.Backward (seconds);
		}
	}
}
