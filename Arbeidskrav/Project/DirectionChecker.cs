using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
///<remark>
///Denne klassen sjekker hvilken direksjon slangen tar
///</remark>
class DirectionChecker
{

    public DirectionChecker() { }
    ///<remark>
	///Tar i mot mySetup klassen for å sjekke hvilken direksjon som du valgte ved å klikke på piltastene,
	///og snur slangen ettersom.
	///</remark>
    public void SetDirections(Setup mySetup)
    {
        switch (mySetup.NewDirection)
        {
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