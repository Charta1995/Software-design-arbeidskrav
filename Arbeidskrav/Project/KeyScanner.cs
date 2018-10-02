using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class KeyScanner {

    public KeyScanner(){}

    public void ScanForKeys(Setup mySetup) {
        if (Console.KeyAvailable) {
			ConsoleKeyInfo cki = Console.ReadKey(true);
			if (cki.Key == ConsoleKey.Escape)
				mySetup.GameOver = true;
			else if (cki.Key == ConsoleKey.Spacebar)
				mySetup.GamePause = !mySetup.GamePause;
			else if (cki.Key == ConsoleKey.UpArrow && mySetup.LastDirection != (int) Direction.Down)
				mySetup.NewDirection = (int) Direction.Up;
			else if (cki.Key == ConsoleKey.RightArrow && mySetup.LastDirection != (int) Direction.Left)
				mySetup.NewDirection = (int) Direction.Right;
			else if (cki.Key == ConsoleKey.DownArrow && mySetup.LastDirection != (int) Direction.Up)
				mySetup.NewDirection = (int) Direction.Down;
			else if (cki.Key == ConsoleKey.LeftArrow && mySetup.LastDirection != 1)
				mySetup.NewDirection = (int) Direction.Left;
		}
    }

}