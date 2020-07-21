using System.ComponentModel;
using System.Net.NetworkInformation;

namespace MarsRoverTechChallenge
{
	public class Constants
	{
		public const string Title = "Mars Rover Tech Challenge";

		public const char Move = 'M';

		public const char Right = 'R';

		public const char Left = 'L';

		public const string InvalidDirection = "Invalid direction {0}";

		public const string InvalidMove = "Invalid Move {0}";

		public const string BeyondBoundaries = "Position can not be the beyond boundaries (0 , 0) and ({0} , {1})";

		public const string PlateauSize = "Please enter the size of the plateau:";

		public const string RoverPosition = "The position for rover {0} is :";

		public const string AddAnotherRover = "Do you want to add another rover (Y = Yes, N = No)?";

		public const string Yes = "Y";

		public const string RoverCrashed = "Rover {0} has crashed. Game over.";

		public const string EnterMoves = "Please enter the moves for rover {0}:";

		public const string EnterPositon = "Please enter the position for rover {0}:";
	}
}
