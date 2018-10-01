using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class GameManager {
    private SnakeFood snakeFood;
    private KeyScanner keyScanner;

    private GameNotPaused gameNotPaused;

    private ConfigureConsole gameIsNotOver;
    private Setup mySetup;

    public GameManager() {
        this.MySetup = new Setup();
        this.MySnakeFood = new SnakeFood();
        this.MyKeyScanner = new KeyScanner();
        this.TheGameIsRunning = new GameNotPaused();
        this.TheGameIsNotOver = new ConfigureConsole();
    }

    public void initializeGame() {
        this.MySnakeFood.SetSnakeFood(this.MySetup);
		this.MySetup.initializeAndStartStopWatch();
    }
    
    public void PlayGame() {
        while(!MySetup.GameOver) {
            this.MyKeyScanner.ScanForKeys(MySetup);

            if (!mySetup.GamePause) {
                if (mySetup.MyStopWatch.ElapsedMilliseconds < 100)
                    continue;
                mySetup.MyStopWatch.Restart();
                mySetup.initializeSnakeAttributes();

                this.TheGameIsRunning.SetDirections(MySetup);
                this.TheGameIsRunning.CheckIfGameOverAndNewFoodPosition(MySetup, this);

                this.TheGameIsRunning.ConfigureSnakeAndCheckIfEatenItself(MySetup);
                this.TheGameIsNotOver.ConfigureConsoleAndSnake(MySetup);
            }
        }
    }


    public Setup MySetup {
        get {
            return this.mySetup;
        }

        private set {
            this.mySetup = value;
        }
    }

    public SnakeFood MySnakeFood {
        get {
            return this.snakeFood;
        }

        private set {
            this.snakeFood = value;
        }
    }

    public KeyScanner MyKeyScanner {
        get {
            return this.keyScanner;
        }

        private set {
            this.keyScanner = value;
        }
    }

    public GameNotPaused TheGameIsRunning {
        get {
            return this.gameNotPaused;
        }

        private set {
            this.gameNotPaused = value;
        }
    }

    public ConfigureConsole TheGameIsNotOver {
        get {
            return this.gameIsNotOver;
        }

        private set {
            this.gameIsNotOver = value;
        }
    }


}