using System;

namespace SnakeGIT
{
    public class Fruits2 : Fruits
    {
        Random rnd = new Random(1);
        Random rng = new Random(3);
        Random rnd1 = new Random(5);

        public void generateFruit(int a)
        {
            switch (a)
            {
                case 1:
                    {
                        x = rnd.Next(Constants.MAPX + Constants.MAPSIZE + 9, Constants.MAPX + 2 * Constants.MAPSIZE + 9);
                        y = rnd.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE);
                        break;
                    }
                case 2:
                    {
                        x = rng.Next(Constants.MAPX + Constants.MAPSIZE + 9, Constants.MAPX + 2 * Constants.MAPSIZE + 9);
                        y = rng.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE);
                        break;
                    }
                case 3:
                    {
                        x = rnd1.Next(Constants.MAPX + Constants.MAPSIZE + 9, Constants.MAPX + 2 * Constants.MAPSIZE + 9);
                        y = rnd1.Next(Constants.MAPY, Constants.MAPY + Constants.MAPSIZE);
                        break;
                    }
                case 4:
                    {
                        x = 100;
                        y = 100;
                        break;
                    }
            }


        }
    }
}