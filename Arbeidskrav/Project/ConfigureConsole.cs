using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class ConfigureConsole {

    public ConfigureConsole() {}
	
	/*
		Sjekker om spillet ikke er over og konfiguerer konsollet og skriver 0 på MySnakeHad x og y,
		mellomrom på halen på slangen, resetter FreeMovementSpace om den er false, legger til slange hodet
		på kroppen og konfiguerer konsollet igjen.
		Til slutt settes det på et nytt hode ved å skrive @ på MyNewSnakeHead posisjon X og Y og deretter
		setter LastDirection til NewDirection.
	 */
    public void ConfigureConsoleAndSnake(Setup mySetup) {
		//Om spillet ikke er over
        if (!mySetup.GameOver) {
			//Konfiguerer konsollet
			Console.ForegroundColor = ConsoleColor.Yellow;
			//Legger til 0 på MySnakeHead punkt x og y
			Console.SetCursorPosition(mySetup.MySnakeHead.X, mySetup.MySnakeHead.Y); 
			Console.Write("0");
			if (mySetup.FreeMovementSpace) {
				//Om det ikke er mat foran slangen altså free movement space så skrives mellomrom på
				//slangen sin hale.
				Console.SetCursorPosition(mySetup.MySnakeTail.X, mySetup.MySnakeTail.Y); 
				Console.Write(" ");
			} else {
				mySetup.FreeMovementSpace = true;
			}
			mySetup.MySnake.Add(mySetup.MyNewSnakeHead);
			//Konfiguerer konsollet og legger til nytt hode på slangen på MyNewSnakeHead sine punkter x og y.
			Console.ForegroundColor = ConsoleColor.Yellow; 
			Console.SetCursorPosition(mySetup.MyNewSnakeHead.X, mySetup.MyNewSnakeHead.Y); 
			Console.Write("@");
			mySetup.LastDirection = mySetup.NewDirection;
		}
    }

}