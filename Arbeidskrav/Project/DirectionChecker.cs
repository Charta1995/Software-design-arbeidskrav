using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class DirectionChecker {

    public DirectionChecker(){}

    public void SetDirections(Setup mySetup) {
        switch (mySetup.NewDirection) {
			case 0:
				mySetup.MyNewSnakeHead.Y -= 1;
				break;
			case 1:
				mySetup.MyNewSnakeHead.X += 1;
		    	break;
			case 2:
				mySetup.MyNewSnakeHead.Y += 1;
				break;
			default:
				mySetup.MyNewSnakeHead.X -= 1;
				break;
		}
    }
}