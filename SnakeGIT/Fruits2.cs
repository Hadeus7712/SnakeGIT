using System;

namespace SnakeGIT
{
    public class Fruits2 : Fruits
    {
        Random rnd = new Random();
        Snake2 snake = new Snake2();

        public void generateFruit()
        {
            do
            {
                x = rnd.Next(Constants.MAPX + Constants.MAPSIZE + 9, Constants.MAPX + 2*Constants.MAPSIZE + 9);
                y = rnd.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE);

            } while (snake.CheckCollision(this.x, this.y));
        }
    }
}