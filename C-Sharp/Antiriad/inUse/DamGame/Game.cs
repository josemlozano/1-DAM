using System;

namespace DamGame
{
    class Game
    {
        private Font font18;
        private Player player;
        private Enemy[] enemies;
        private Level currentLevel;
        private bool finished;
        private int numEnemies;
        private byte lives = 3;
        private int score = 0;
        protected Score[] objects;
        private byte numObjects;

        public Game()
        {
            font18 = new Font("data/Joystix.ttf", 18);
            player = new Player(this);

            Random rnd = new Random();
            numEnemies = 2;
            numObjects = 2;
            enemies = new Enemy[numEnemies];
            objects = new Score[numObjects];
            for (int i = 0; i < numEnemies; i++)
            {
                enemies[i] = new Enemy(rnd.Next(200, 800), rnd.Next(100, 450));
                enemies[i].SetSpeed(rnd.Next(1, 3), 1);
            }
            for (int j = 0; j < numObjects; j++)
            {
                objects[j] = new Score(rnd.Next(100, 501), rnd.Next(300, 400));
            }

            currentLevel = new Level();
            finished = false;
        }


        // Update screen
        public void DrawElements()
        {
            Hardware.ClearScreen();

            currentLevel.DrawOnHiddenScreen();
            Hardware.WriteHiddenText("Score: " + score,
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);

            Hardware.WriteHiddenText("Lives: " + lives,
                400, 10,
                0xCC, 0xCC, 0xCC,
                font18);

            player.DrawOnHiddenScreen();
            for (int i = 0; i < numEnemies; i++)
                enemies[i].DrawOnHiddenScreen();
            for (int j = 0; j < numObjects; j++)
                objects[j].DrawOnHiddenScreen();
            Hardware.ShowHiddenScreen();
        }


        // Check input by the user
        public void CheckKeys()
        {
            if (Hardware.KeyPressed(Hardware.KEY_UP))
            {
                if (Hardware.KeyPressed(Hardware.KEY_RIGHT))
                    player.JumpRight();
                else
                if (Hardware.KeyPressed(Hardware.KEY_LEFT))
                    player.JumpLeft();
                else
                    player.Jump();
            }

            else if (Hardware.KeyPressed(Hardware.KEY_RIGHT))
                player.MoveRight();


            else if (Hardware.KeyPressed(Hardware.KEY_LEFT))
                player.MoveLeft();

            //if (Hardware.KeyPressed(Hardware.KEY_DOWN))
            //    player.MoveDown();

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = true;
        }


        // Move enemies, animate background, etc 
        public void MoveElements()
        {
            player.Move();
            for (int i = 0; i < numEnemies; i++)
            {
                enemies[i].MoveToPlayer(player.GetX(), player.GetY());
                enemies[i].Move();
            }
        }


        // Check collisions and apply game logic
        public void CheckCollisions()
        {
            for (int i = 0; i < numEnemies; i++)
                if (enemies[i].CollisionsWith(player))
                {
                    lives--;
                    player.Restart();
                    if (lives == 0)
                        finished = true;
                }
            for (int j = 0; j < numObjects; j++)
                if (objects[j].CollisionsWith(player))
                {
                    score += 20;
                    objects[j].Hide();
                }
        }

        public void PauseTillNextFrame()
        {
            // Pause till next frame (20 ms = 50 fps)
            Hardware.Pause(20);
        }

        public void Run()
        {
            // Game Loop
            while (!finished)
            {
                DrawElements();
                CheckKeys();
                MoveElements();
                CheckCollisions();
                PauseTillNextFrame();
            }
        }

        public bool IsValidMove(int xMin, int yMin, int xMax, int yMax)
        {
            return currentLevel.IsValidMove(xMin, yMin, xMax, yMax);
        }
    }
}
