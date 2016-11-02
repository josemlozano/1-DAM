namespace DamGame
{
    class Enemy : Sprite
    {
        public Enemy(int newX, int newY)
        {
            LoadSequence(LEFT,
                new string[] { "data/bird.png" , "data/bird2.png" });
            LoadSequence(RIGHT,
                new string[] { "data/birdR1.png", "data/bird2R2.png" });
            ChangeDirection(LEFT);
            x = newX;
            y = newY;
            xSpeed = 3;
            ySpeed = 3;
            width = 48;
            height = 48;
            stepsTillNextFrame = 15;
        }
        
        public void MoveToPlayer(int xPlayer, int yPlayer)
        {
            if(x > xPlayer)
            {
                if (((x + xSpeed) - xPlayer) > (x - xPlayer))
                {
                    xSpeed = -xSpeed;
                }
            }
            else if (x < xPlayer)
            {
                if ((xPlayer - (x + xSpeed)) > (xPlayer - x))
                {
                    xSpeed = -xSpeed;
                }
            }

            if (y > yPlayer)
            {
                if (((y + ySpeed) - yPlayer) > (y - yPlayer))
                {
                    ySpeed = -ySpeed;
                }
            }
            else if (y < yPlayer)
            {
                if ((yPlayer - (y + ySpeed)) > (yPlayer - y))
                {
                    ySpeed = -ySpeed;
                }
            }


        }

        public override void Move()
        {
            y = (short)(y + ySpeed);

            if ((x > 1024 - width) || (x < 0))
                xSpeed = -xSpeed;
            x = (short)(x + xSpeed);

            if (xSpeed < 0)
            {
                ChangeDirection(LEFT);
            }
            else
            {
                ChangeDirection(RIGHT);
            }

            NextFrame();
        }
    }
}
