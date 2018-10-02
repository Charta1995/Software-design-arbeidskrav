using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class GameOver {

    public GameOver(){}

    public void CheckIfGameOverAndNewFoodPosition(Setup mySetup, GameManager gameManager) {
        if (mySetup.MyNewSnakeHead.X < 0 || mySetup.MyNewSnakeHead.X >= Console.WindowWidth) {
            mySetup.GameOver = true;
        } else if (mySetup.MyNewSnakeHead.Y < 0 || mySetup.MyNewSnakeHead.Y >= Console.WindowHeight) {
            mySetup.GameOver = true;
        }

        if (mySetup.MyNewSnakeHead.X == mySetup.AppPoint.X && mySetup.MyNewSnakeHead.Y == mySetup.AppPoint.Y) {
            if (mySetup.MySnake.Count + 1 >= Console.WindowWidth * Console.WindowHeight) {
                mySetup.GameOver = true;
            } else {
                gameManager.MySnakeFood.SetSnakeFood(mySetup);
            }
        }
    }

    public void ConfigureSnakeAndCheckIfEatenItself(Setup mySetup) {
        if (mySetup.FreeMovementSpace) {
			mySetup.MySnake.RemoveAt(0);
			foreach (Point x in mySetup.MySnake)
				if (x.X == mySetup.MyNewSnakeHead.X && x.Y == mySetup.MyNewSnakeHead.Y) {
					// Death by accidental self-cannibalism.
					mySetup.GameOver = true;
					break;
				}
		}
    }

}