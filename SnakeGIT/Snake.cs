using System.Collections.Generic;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectInput;

namespace SnakeGIT
{
    public class Snake : Drawable
    {
        public Queue<Point> trail = new Queue<Point>();
        public int tail = Constants.INITIAL_TAIL;
        public int dx;
        public int dy;
        public int score;
        public int speed = 3;
        public int hp = Constants.HP;

        Stats stats = new SnakeStats();

        public Keyboard keyboard;

         
        public void init()
        {
            var directInput = new DirectInput();
            keyboard = new Keyboard(directInput);
            keyboard.Acquire();
            //trail.Enqueue(new Point { X = x, Y = y });
        }
        public bool CheckCollision(int x, int y)
        {
            foreach (var element in trail)
            {
                if (element.X == x && element.Y == y)
                    return true;
            }
            return false;
        }


        public bool CheckCollision(int x, int y, int f)
        {
            foreach (var element in trail)
            {
                if (element.X == x || element.Y == y)
                    return true;
            }
            return false;
        }

        public void Update()
        {
            x = (x + dx + Constants.SCREEN_SIZE) % Constants.SCREEN_SIZE;
            y = (y + dy + Constants.SCREEN_SIZE) % Constants.SCREEN_SIZE;

            if (CheckCollision(x, y) || CheckCollision(Constants.MAPX - 1, Constants.MAPY - 1, 1) || CheckCollision(Constants.MAPX + Constants.MAPSIZE, Constants.MAPY + Constants.MAPSIZE, 1))
            {
                x = y = 12;
                dx = 0;
                dy = 1;
                tail = Constants.INITIAL_TAIL;
                score = 0;
                hp--;
            }


            trail.Enqueue(new Point { X = x, Y = y });
            while (trail.Count > tail)
            {
                trail.Dequeue();
            }

        }

        public void Draw(RenderTarget renderTarget, SharpDX.Direct2D1.Factory factory)
        {
            foreach (var element in trail)
            {
                var x = element.X * Constants.SPRITE_SIZE + 1;
                var y = element.Y * Constants.SPRITE_SIZE + 1;
                var rectangleGeometry = new RectangleGeometry(factory, new RectangleF(x, y, width, height));
                renderTarget.FillGeometry(rectangleGeometry, brush, null);
            }
        }


        public bool HandleInput()
        {
            var state = keyboard.GetCurrentState();
            if (dx == 0)
            {
                if (state.IsPressed(Key.A))
                {
                    dx = -1;
                    dy = 0;
                }
                else if (state.IsPressed(Key.D))
                {
                    dx = 1;
                    dy = 0;
                }
            }
            if (dy == 0)
            {
                if (state.IsPressed(Key.W))
                {
                    dx = 0;
                    dy = -1;
                }
                if (state.IsPressed(Key.S))
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