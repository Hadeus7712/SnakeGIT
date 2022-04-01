using System;

namespace SnakeGIT
{
    public class Fruits1 : Fruits
    {
        Random rnd = new Random(1);
        Random rng = new Random(3);
        Snake snake = new Snake();

        public void generateFruit(int a)
        {
            if(a == 1)
            {
                x = rnd.Next(Constants.MAPX, Constants.MAPX + Constants.MAPSIZE);
                y = rnd.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE);
            }
            if(a == 2)
            {
                x = rng.Next(Constants.MAPX, Constants.MAPX + Constants.MAPSIZE)+1;
                y = rng.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE)+1;
            }

        }
    }
}