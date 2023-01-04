using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeGame game = new SnakeGame();
            game.Start();
        }
    }
    // définition des attributs
    public class SnakeGame
    {
        private const int GRID_SIZE_X = 100;
        private const int GRID_SIZE_Y = 20;
        private int[] grid_x;
        private int[] grid_y;
        private List<Position> snakePositions;
        private Position foodPosition;
        private Direction currentDirection;
        private int score;
        Direction? direction = null;


        public SnakeGame()
        {
            this.grid_x = new int[GRID_SIZE_X];
            this.grid_y = new int[GRID_SIZE_Y];
            this.snakePositions = new List<Position>();
            this.snakePositions.Add(new Position(GRID_SIZE_X / 2, GRID_SIZE_Y / 2));
            this.foodPosition = new Position(0, 0);
            this.score = 0;
        }

        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(25);
                Update();
                Render();
                while (Console.KeyAvailable && !direction.HasValue)
                {
                    KeyPressed();
                }
            }
        }
        // mise a jour de l'affichage
        private void Update()
        {
            MoveSnake();
            CheckForFood();
            if (score == 30)
            {
                Victory();
            }
        }

        private void Render()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Score: {0}", this.score);
            for (int y = 0; y < GRID_SIZE_Y; y++)
            {
                for (int x = 0; x < GRID_SIZE_X; x++)
                {
                    // si position actuelle = celle du serpent
                    bool isSnakeHere = false;
                    foreach (Position pos in snakePositions)
                    {
                        if (pos.X == x && pos.Y == y)
                        {
                            isSnakeHere = true;
                            break;
                        }
                    }

                    // détermine si la position du serpent = celle de la nourriture
                    bool isFood = (foodPosition.X == x && foodPosition.Y == y);

                    // affichage
                    if (isSnakeHere)
                        {
                        Console.Write("@", ConsoleColor.Red);
                    }
                    else if (isFood)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
        private void KeyPressed()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    currentDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    currentDirection = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    currentDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    currentDirection = Direction.Right;
                    break;
            }
        }
        private void MoveSnake()
        {
            Position head = snakePositions[0];
            Position newHead = new Position(head.X, head.Y);
            switch (currentDirection)
            {
                case Direction.Up:
                    newHead.Y--;
                    break;
                case Direction.Down:
                    newHead.Y++;
                    break;
                case Direction.Left:
                    newHead.X--;
                    break;
                case Direction.Right:
                    newHead.X++;
                    break;
            }
            // si on touche un bord de grille
            if (newHead.X < 0 || newHead.X >= GRID_SIZE_X ||
                newHead.Y < 0 || newHead.Y >= GRID_SIZE_Y)
            {
                EndGame();
            }
            else
            {
                // vérifie si le serpent se mord
                foreach (Position pos in snakePositions)
                {
                    if (pos.X == newHead.X && pos.Y == newHead.Y)
                    {
                        EndGame();
                        return;
                    }
                }
                snakePositions.Insert(0, newHead);
                if (snakePositions.Count > this.score + 1)
                    snakePositions.RemoveAt(snakePositions.Count - 1);
            }
        }

        private void CheckForFood()
        {
            Position head = snakePositions[0];
            if (head.X == foodPosition.X && head.Y == foodPosition.Y)
            {
                GenerateFoodPosition();
                this.score++;
            }
        }
        private void GenerateFoodPosition()
        {
            Random random = new Random();

            while (true)
            {
                int x = random.Next(0, GRID_SIZE_X);
                int y = random.Next(0, GRID_SIZE_Y);
                bool isValid = true;
                foreach (Position pos in snakePositions)
                {
                    if (pos.X == x && pos.Y == y)   

                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    foodPosition = new Position(x, y);
                    break;
                }
            }
        }
        private void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.WriteLine("Score: {0}", this.score);
            Console.ReadKey();

            Environment.Exit(0);
        }
        
        private void Victory()
        {
            Console.Clear();
            Console.WriteLine("Victory !!");
            Console.WriteLine("Score: {0}", this.score);
            Console.ReadKey();

            Environment.Exit(0);
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
