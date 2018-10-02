using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class ConfigureConsole {

    public ConfigureConsole() {}

    public void ConfigureConsoleAndSnake(Setup mySetup) {
        if (!mySetup.GameOver) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(mySetup.MySnakeHead.X, mySetup.MySnakeHead.Y); 
			Console.Write("0");
			if (mySetup.FreeMovementSpace) {
				Console.SetCursorPosition(mySetup.MySnakeTail.X, mySetup.MySnakeTail.Y); 
				Console.Write(" ");
			} else {
				mySetup.FreeMovementSpace = true;
			}
			mySetup.MySnake.Add(mySetup.MyNewSnakeHead);
			Console.ForegroundColor = ConsoleColor.Yellow; 
			Console.SetCursorPosition(mySetup.MyNewSnakeHead.X, mySetup.MyNewSnakeHead.Y); 
			Console.Write("@");
			mySetup.LastDirection = mySetup.NewDirection;
		}
    }

}