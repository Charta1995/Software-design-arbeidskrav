using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class GameNotPaused {

    public GameNotPaused(){}

    public void SetDirections(Setup mySetup) {
        switch (mySetup.NewDirection) {
			case 0:
				mySetup.MySnakeHeight.Y -= 1;
				break;
			case 1:
				mySetup.MySnakeHeight.X += 1;
		    	break;
			case 2:
				mySetup.MySnakeHeight.Y += 1;
				break;
			default:
				mySetup.MySnakeHeight.X -= 1;
				break;
		}
    }

    public void CheckIfGameOverAndNewFoodPosition(Setup mySetup) {
        if (mySetup.MySnakeHeight.X < 0 || mySetup.MySnakeHeight.X >= Console.WindowWidth) {
            mySetup.GameOver = true;
        } else if (mySetup.MySnakeHeight.Y < 0 || mySetup.MySnakeHeight.Y >= Console.WindowHeight) {
            mySetup.GameOver = true;
        }

        if (mySetup.MySnakeHeight.X == mySetup.AppPoint.X && mySetup.MySnakeHeight.Y == mySetup.AppPoint.Y) {
            if (mySetup.MySnake.Count + 1 >= Console.WindowWidth * Console.WindowHeight) {
                mySetup.GameOver = true;
            } else {
                CheckForNewFoodPosition(mySetup);
            }
        }
    }
    private void CheckForNewFoodPosition(Setup mySetup) {
        while(true) {
            mySetup.AppPoint.X = mySetup.RandomSpot.Next(0, Console.WindowWidth);
            mySetup.AppPoint.Y = mySetup.RandomSpot.Next(0, Console.WindowHeight);
            bool freeSpotFound = true;
            foreach(Point snakePoint in mySetup.MySnake) {
                if (snakePoint.X == mySetup.AppPoint.X && snakePoint.Y == mySetup.AppPoint.Y) {
                    freeSpotFound = false;
                    break;
                }
            }
            if (freeSpotFound) {
                mySetup.InUse = true;
                break;
            }
        }
    }

    public void ConfigureSnakeAndCheckIfEatenItself(Setup mySetup) {
        if (!mySetup.InUse) {
			mySetup.MySnake.RemoveAt(0);
			foreach (Point x in mySetup.MySnake)
				if (x.X == mySetup.MySnakeHeight.X && x.Y == mySetup.MySnakeHeight.Y) {
					// Death by accidental self-cannibalism.
					mySetup.GameOver = true;
					break;
				}
		}
    }

}