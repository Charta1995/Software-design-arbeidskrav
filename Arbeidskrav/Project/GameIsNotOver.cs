using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class GameIsNotOver {

    public GameIsNotOver(){}

    public void ConfigureConsoleAndSnake(Setup mySetup) {
        if (!mySetup.GameOver) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(mySetup.MySnakeHead.X, mySetup.MySnakeHead.Y); 
			Console.Write("0");
			if (!mySetup.InUse) {
				Console.SetCursorPosition(mySetup.MySnakeTail.X, mySetup.MySnakeTail.Y); 
				Console.Write(" ");
			} else {
				Console.ForegroundColor = ConsoleColor.Green; 
				Console.SetCursorPosition(mySetup.AppPoint.X, mySetup.AppPoint.Y); 
				Console.Write("$");
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