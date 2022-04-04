using System.Collections.Generic;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectInput;
//АГУ: Смешивать слова обращение к разным уровням в одном предложении НЕЛЬЯЗ!!!!
namespace SnakeGIT
{
    public class Snake2 : Snake
    {
        public new int dx;
        public new int dy;
        public new int speed = 6;

        public new bool death;
        public new void Update()
        {
            death = false;

            x = (x + dx + Constants.SCREEN_SIZE) % Constants.SCREEN_SIZE;
            y = (y + dy + Constants.SCREEN_SIZE) % Constants.SCREEN_SIZE;

            if (CheckCollision(x, y) || CheckCollision(Constants.MAPX + Constants.MAPSIZE + 8, Constants.MAPY - 1, 1) || CheckCollision(Constants.MAPX + 2*Constants.MAPSIZE + 9, Constants.MAPY + Constants.MAPSIZE, 1))
            {
                x = 47; 
                y = 12;
                dx = 0;
                dy = 1;
                tail = Constants.INITIAL_TAIL;
                death = true;
            }

            trail.Enqueue(new Point { X = x, Y = y });
            while (trail.Count > tail)
            {
                trail.Dequeue();
            }
        }

        public new bool CheckCollision(int x, int y)
        {
            foreach (var element in trail)
            {
                if (element.X == x && element.Y == y)
                    return true;
            }
            return false;
        }

        public new bool CheckCollision(int x, int y, int f)
        {
            foreach (var element in trail)
            {
                if (element.X == x || element.Y == y)
                    return true;
            }
            return false;
        }
        public new bool HandleInput()
        {
            var state = keyboard.GetCurrentState();
            if (dx == 0)
            {
                if (state.IsPressed(Key.Left))
                {
                    dx = -1;
                    dy = 0;
                }
                else if (state.IsPressed(Key.Right))
                {
                    dx = 1;
                    dy = 0;
                }
            }
            if (dy == 0)
            {
                if (state.IsPressed(Key.Up))
                {
                    dx = 0;
                    dy = -1;
                }
                if (state.IsPressed(Key.Down))
                {
                    dx = 0;
                    dy = 1;
                }
            }
            if (state.IsPressed(Key.Escape))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}