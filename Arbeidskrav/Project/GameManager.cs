using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class GameManager
{
    private SnakeFood snakeFood;
    private KeyScanner keyScanner;

    private DirectionChecker directionChecker;

    private ConfigureConsole configureConsole;
    private Setup mySetup;

    private GameOver gameOver;

    public GameManager()
    {
        this.MySetup = new Setup();
        this.MySnakeFood = new SnakeFood();
        this.MyKeyScanner = new KeyScanner();
        this.TheDirectionChecker = new DirectionChecker();
        this.TheConfigureConsole = new ConfigureConsole();
        this.MyGameOver = new GameOver();
    }

    public void initializeGame()
    {
        this.MySnakeFood.SetSnakeFood(this.MySetup);
        this.MySetup.initializeAndStartStopWatch();
    }

    public void PlayGame()
    {
        while (!MySetup.GameOver)
        {
            this.MyKeyScanner.ScanForKeys(MySetup);

            if (!mySetup.GamePause)
            {
                if (mySetup.MyStopWatch.ElapsedMilliseconds < 100)
                    continue;
                mySetup.MyStopWatch.Restart();
                mySetup.initializeSnakeAttributes();

                this.TheDirectionChecker.SetDirections(MySetup);

                this.MyGameOver.CheckIfGameOverAndNewFoodPosition(mySetup, this);
                this.MyGameOver.ConfigureSnakeAndCheckIfEatenItself(mySetup);

                this.TheConfigureConsole.ConfigureConsoleAndSnake(MySetup);
            }
        }
    }


    public Setup MySetup
    {
        get
        {
            return this.mySetup;
        }

        private set
        {
            this.mySetup = value;
        }
    }

    public SnakeFood MySnakeFood
    {
        get
        {
            return this.snakeFood;
        }

        private set
        {
            this.snakeFood = value;
        }
    }

    public KeyScanner MyKeyScanner
    {
        get
        {
            return this.keyScanner;
        }

        private set
        {
            this.keyScanner = value;
        }
    }

    public DirectionChecker TheDirectionChecker
    {
        get
        {
            return this.directionChecker;
        }

        private set
        {
            this.directionChecker = value;
        }
    }

    public ConfigureConsole TheConfigureConsole
    {
        get
        {
            return this.configureConsole;
        }

        private set
        {
            this.configureConsole = value;
        }
    }

    public GameOver MyGameOver
    {
        get
        {
            return this.gameOver;
        }

        private set
        {
            this.gameOver = value;
        }
    }


}