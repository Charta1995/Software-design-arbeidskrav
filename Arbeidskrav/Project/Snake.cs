using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Snake
{
	
	class Snake
	{
		public static void Main(string[] arguments)
		{
			GameManager MyGameManager = new GameManager();
			MyGameManager.initializeGame();
			MyGameManager.PlayGame();
		}
	}
}