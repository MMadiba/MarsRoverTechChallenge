using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverTechChallenge
{
	internal class Program
	{
		internal static void Main(string[] args)
		{
			Console.WriteLine(Constants.Title);
			Console.WriteLine(Constants.PlateauSize);
			var rovers = 1;
			var roverPositions = new List<RoverPosition>();
			var boundaries = Console.ReadLine()?.Trim().Split(' ').Select(int.Parse).ToList();


			while (rovers != 0)
			{
			
				var position = GetRoverPosition(rovers);

				var moves = GetMoves(rovers);

				try
				{
					position.Move(moves, boundaries);
					Console.WriteLine(Constants.RoverPosition, rovers);
					Console.WriteLine($"{position.X} {position.Y} {position.Direction}");
					roverPositions.Add(position);
					CheckCollisions(roverPositions, rovers);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

				Console.WriteLine(Constants.AddAnotherRover);
				var addRover = Console.ReadLine();
				if (addRover != null && addRover.ToUpper().Equals(Constants.Yes))
				{
					rovers++;
				}
				else
				{
					rovers = 0;
				}
			}

			Console.ReadLine();
		}

		private static void CheckCollisions(List<RoverPosition> roverPositions, int rovers)
		{
			var collisions = roverPositions
				.GroupBy(x => x.X, x => x.Y)
				.Any(e => e.Count() > 1);
			if (!collisions) return;
			Console.WriteLine(Constants.RoverCrashed, rovers);
			Console.ReadLine();
			Environment.Exit(-1);
		}

		private static string GetMoves(int rovers)
		{
			Console.WriteLine(Constants.EnterMoves,rovers);
			var moves = Console.ReadLine()?.ToUpper();
			return moves;
		}

		private static RoverPosition GetRoverPosition(int rovers)
		{
			Console.WriteLine(Constants.EnterPositon, rovers);
			var startPositions = Console.ReadLine()?.ToUpper().Trim().Split(' ');
			var position = new RoverPosition();

			if (startPositions == null || startPositions.Count() != 3) return position;
			position.X = Convert.ToInt32(startPositions[0]);
			position.Y = Convert.ToInt32(startPositions[1]);
			position.Direction = (Enums.Directions) Enum.Parse(typeof(Enums.Directions), startPositions[2]);

			return position;
		}
	}
}
