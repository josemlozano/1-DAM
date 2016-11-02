namespace DamGame
{
    class Score : Sprite
    {
        public Score(int newX, int newY)
        {
            LoadImage("data/money.png");
            x = newX;
            y = newY;
            visible = true;
        }
    }
}
