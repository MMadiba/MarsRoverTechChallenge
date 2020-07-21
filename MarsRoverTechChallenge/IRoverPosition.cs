using System.Collections.Generic;

namespace MarsRoverTechChallenge
{
	public interface IRoverPosition
	{
		void Move(string moves, List<int> boundaries);
	}
}
