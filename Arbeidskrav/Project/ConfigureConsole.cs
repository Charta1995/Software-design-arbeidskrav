using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class ConfigureConsole {

    public ConfigureConsole(){}

    public void ConfigureConsoleAndSnake(Setup mySetup) {
        if (!mySetup.GameOver) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(mySetup.MySnakeHead.X, mySetup.MySnakeHead.Y); 
			Console.Write("0");
			if (!mySetup.InUse) {
				Console.SetCursorPosition(mySetup.MySnakeTail.X, mySetup.MySnakeTail.Y); 
				Console.Write(" ");
			} else {
				 mySetup.InUse = false;
				
			}
			mySetup.MySnake.Add(mySetup.MySnakeHeight);
			Console.ForegroundColor = ConsoleColor.Yellow; 
			Console.SetCursorPosition(mySetup.MySnakeHeight.X, mySetup.MySnakeHeight.Y); 
			Console.Write("@");
			mySetup.LastDirection = mySetup.NewDirection;
		}
    }

}