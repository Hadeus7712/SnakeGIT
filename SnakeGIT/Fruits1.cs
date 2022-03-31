using System;

namespace SnakeGIT
{
    public class Fruits1 : Fruits
    {
        Random rnd = new Random();
        Snake snake = new Snake();

        public void generateFruit()
        {
            do
            {
                 x = rnd.Next(Constants.MAPX, Constants.MAPX + Constants.MAPSIZE);
                 y = rnd.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE);

            } while (snake.CheckCollision(this.x, this.y));
        }
    }
}