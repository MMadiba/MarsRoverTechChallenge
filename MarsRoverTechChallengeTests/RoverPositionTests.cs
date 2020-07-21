using System.Collections.Generic;
using MarsRoverTechChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MarsRoverTechChallengeTests
{
	[TestClass()]
	public class RoverPositionTests
	{
		[TestMethod()]
		public void MoveTest1()
		{
			var boundaries = GetBoundaries();
			const string moves = "LMLMLMLMM";
			var roverPosition = new RoverPosition();
			roverPosition.X = 1;
			roverPosition.Y = 2;
			roverPosition.Direction = Enums.Directions.N;
			roverPosition.Move(moves, boundaries);
			//1 3 N
			Assert.AreEqual(1, roverPosition.X);
			Assert.AreEqual(3, roverPosition.Y);
			Assert.AreEqual(Enums.Directions.N, roverPosition.Direction);
		}

		[TestMethod()]
		public void MoveTest2()
		{
			var boundaries = GetBoundaries();
			const string moves = "MMRMMRMRRM";
			var roverPosition = new RoverPosition();
			roverPosition.X = 3;
			roverPosition.Y = 3;
			roverPosition.Direction = Enums.Directions.E;
			roverPosition.Move(moves, boundaries);
			//5 1 E
			Assert.AreEqual(5, roverPosition.X);
			Assert.AreEqual(1, roverPosition.Y);
			Assert.AreEqual(Enums.Directions.E, roverPosition.Direction);
		}

		private static List<int> GetBoundaries()
		{
			var boundaries = new List<int>();
			boundaries.Add(5);
			boundaries.Add(5);
			return boundaries;
		}
	}
}