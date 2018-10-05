using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

///<summary>
///SnakeFood klassen.
///Klasse som kan opptrette mat til slangen.
///</summary>
///<remarks>
///<para>Denne klassen kan sette et tilfelig pungt på brettet som slangen kan bruke til mat.</para>
///<para>Maten blir opptrettet der slangen ikke befinner seg.</para>
///</remakrs>
class SnakeFood
{

    public SnakeFood() { }

    public void SetSnakeFood(Setup mySetup)
    {
        while (true)
        { //Når denne er sann så kalles denne logikken.
            mySetup.AppPoint.X = mySetup.RandomSpot.Next(0, Console.WindowWidth);
            mySetup.AppPoint.Y = mySetup.RandomSpot.Next(0, Console.WindowHeight);
            bool freeSpotFound = true;
            foreach (Point SnakePoint in mySetup.MySnake)
                if (SnakePoint.X == mySetup.AppPoint.X && SnakePoint.Y == mySetup.AppPoint.Y)
                {
                    freeSpotFound = false;
                    break;
                }

            if (freeSpotFound)
            {
                //Hvis det er en plass på brettet der slangen ikke befinner seg så kalles denne logikken.
                //FreeMovementspace blir satt til false da det ikke er fritt.
                mySetup.FreeMovementSpace = false;
                //Foregroundfargen blir satt til grønn.
                Console.ForegroundColor = ConsoleColor.Green;
                //Maten blir satt tilfeldig på et pungt bassert på tilfeldig X og Y.
                Console.SetCursorPosition(mySetup.AppPoint.X, mySetup.AppPoint.Y);
                //Vi skriver "maten" i konsollen.
                Console.Write("$");
                break;
            }
        }
    }

}