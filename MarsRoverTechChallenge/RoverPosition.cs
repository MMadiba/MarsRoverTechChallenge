using System;
using System.Collections.Generic;

namespace MarsRoverTechChallenge
{
	public class RoverPosition : IRoverPosition
	{
		public int X { get; set; }
		public int Y { get; set; }
		public Enums.Directions Direction { get; set; }

		public RoverPosition()
		{
			X = 0;
			Y = 0;
			Direction = Enums.Directions.N;
		}

		private void Move()
		{
			switch (Direction)
			{
				case Enums.Directions.N:
					Y++;
					break;
				case Enums.Directions.S:
					Y--;
					break;
				case Enums.Directions.E:
					X++;
					break;
				case Enums.Directions.W:
					X--;
					break;
				default:
					throw new Exception(string.Format(Constants.InvalidDirection, Direction));
			}
		}

		private void Spin90DegreesRight()
		{
			Direction = Direction switch
			{
				Enums.Directions.N => Enums.Directions.E,
				Enums.Directions.S => Enums.Directions.W,
				Enums.Directions.E => Enums.Directions.S,
				Enums.Directions.W => Enums.Directions.N,
				_ => Direction
			};
		}

		private void Spin90DegreesLeft()
		{
			Direction = Direction switch
			{
				Enums.Directions.N => Enums.Directions.W,
				Enums.Directions.S => Enums.Directions.E,
				Enums.Directions.E => Enums.Directions.N,
				Enums.Directions.W => Enums.Directions.S,
				_ => Direction
			};
		}

		public void Move(string moves, List<int> boundaries)
		{
			foreach (var move in moves)
			{
				switch (move)
				{
					case Constants.Move:
						Move();
						break;
					case Constants.Right:
						Spin90DegreesRight();
						break;
					case Constants.Left:
						Spin90DegreesLeft();
						break;
					default:
						Console.WriteLine(Constants.InvalidMove, move);
						break;
				}

				if (X < 0 ||  Y < 0 || X > boundaries[0] || Y > boundaries[1])
				{
					throw new Exception(string.Format(Constants.BeyondBoundaries, boundaries[0],boundaries[1]));
				}
			}
		}

	}
}
