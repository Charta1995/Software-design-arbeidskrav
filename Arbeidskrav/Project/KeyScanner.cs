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
			else if (cki.Key == ConsoleKey.UpArrow && mySetup.LastDirection != 2)
				mySetup.NewDirection = 0;
			else if (cki.Key == ConsoleKey.RightArrow && mySetup.LastDirection != 3)
				mySetup.NewDirection = 1;
			else if (cki.Key == ConsoleKey.DownArrow && mySetup.LastDirection != 0)
				mySetup.NewDirection = 2;
			else if (cki.Key == ConsoleKey.LeftArrow && mySetup.LastDirection != 1)
				mySetup.NewDirection = 3;
		}
    }

}