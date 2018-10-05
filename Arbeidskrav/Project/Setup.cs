using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class Setup {

    private bool gameOver;
    private bool gamePause;
    private bool freeMovementSpace;

    private short newDirection;
    private short lastDirection;

    private Random randomSpot;
    private Point appPoint;
    private List<Point> mySnake;

    private Stopwatch stopwatch;

    private Point snakeTail;

    private Point snakeHead;

    private Point newSnakeHead;


    public Setup() {
        initializeStandardValues();
    }

    ///<summary>
    ///Initialiserer variabler og oppretter objekter til denne klassen.
    ///</summary>
    private void initializeStandardValues() {
        GameOver = false;
        GamePause = false;
        FreeMovementSpace = true;

        NewDirection = (short) Direction.Down;
        LastDirection = NewDirection;

        RandomSpot = new Random();
        AppPoint = new Point();
        MySnake = new List<Point>();
        addItemsToSnake();
        initConsole();
    }

    ///<summary>
    ///Oppretter slange kroppen
    ///</summary>
    private void addItemsToSnake() {
        this.mySnake.Add(new Point(10, 10));
        this.mySnake.Add(new Point(10, 10));
        this.mySnake.Add(new Point(10, 10));
        this.mySnake.Add(new Point(10, 10));
    }
    
    ///<summary>
    //Konfiguerer spill vinduet og laget slange hodet.
    ///</summary>
    private void initConsole() {
        Console.CursorVisible = false;
        Console.Title = "Arbeidskrav";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(10, 10);
        Console.Write("@");
    }

    public void initializeAndStartStopWatch() {
        this.MyStopWatch = new Stopwatch();
        this.MyStopWatch.Start();
    }

    public void initializeSnakeAttributes() {
        this.MySnakeHead = new Point(this.MySnake.Last());
        this.MySnakeTail = new Point(this.MySnake.First());
        this.MyNewSnakeHead = new Point(this.MySnakeHead);
    }

    public bool GameOver {
        get {
            return this.gameOver;
        }

        set {
            this.gameOver = value;
        }
    }

    public bool GamePause {
        get {
            return this.gamePause; 
        }

        set {
            this.gamePause = value;
        }
    }

    public bool FreeMovementSpace {
        get {
            return this.freeMovementSpace;
        }

        set {
            this.freeMovementSpace = value;
        }
    }

    public short NewDirection {
        get {
            return this.newDirection;
        }

        set {
            this.newDirection = value;
        }
    }

    public short LastDirection {
        get {
            return this.lastDirection;
        }

        set {
            this.lastDirection = value;
        }
    }

    public Random RandomSpot {
        get {
            return this.randomSpot;
        }

        set {
            this.randomSpot = value;
        }
    }

    public Point AppPoint {
        get {
            return this.appPoint;
        }

        set {
            this.appPoint = value;
        }
    }

    public List<Point> MySnake {
        get {
            return this.mySnake;
        }

        set {
            this.mySnake = value;
        }
    }

    public Stopwatch MyStopWatch {
        get {
            return this.stopwatch;
        }

        private set {
            this.stopwatch = value;
        }
    }

    public Point MySnakeTail {
        get {
            return this.snakeTail;
        }

        private set {
            this.snakeTail = value;
        }
    }

    public Point MySnakeHead {
        get {
            return this.snakeHead;
        }

        private set {
            this.snakeHead = value;
        }
    }

    public Point MyNewSnakeHead {
        get {
            return this.newSnakeHead;
        }

        private set {
            this.newSnakeHead = value;
        }
    }

}