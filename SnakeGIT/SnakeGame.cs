using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using System.Diagnostics;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DirectInput;
using SharpDX.DXGI;
using SharpDX.Windows;



using SharpDX.DirectWrite;

using AlphaMode = SharpDX.Direct2D1.AlphaMode;
using Device = SharpDX.Direct3D11.Device;
using Factory = SharpDX.DXGI.Factory;

namespace SnakeGIT
{
    public struct Point
    {
        public int X;
        public int Y;
    }

    public partial class SnakeGame : IDisposable
    {


        Text text;

        RenderForm form;
        RenderTarget d2dRenderTarget;
        SwapChain swapChain;
        Device device;
        Factory factory;
        Texture2D backBuffer;
        RenderTargetView renderView;
        SharpDX.Direct2D1.Factory d2dFactory;

        Random rng, rnd;
        Stopwatch stopwatch;

        public float previousTicks;
        public float dt;

        Color red = Color.Red;
        Color green = Color.Green;

        Fruits1 apple, hpfruit, scorefruit, speedfruit;
        Fruits2 apple2, hp2fruit, score2fruit, speed2fruit;
        Snake snake;
        Snake2 snake2;

        Stats snakescore, snakehp, snakespeed;
        Stats snake2score, snake2hp, snake2speed;


        HealthBar hp;


        Map map;

        bool sleeping = false;
        int frame, speedFrame, speed2Frame = 0;


        int bonusTime = 0, bonus2Time = 0;
        bool eatBonus = true, eat2Bonus = true;

        int dice, dice2;

        bool bonusflag = false;
        bool bonus2flag = false;

        bool speed = false;
        bool speed2 = false;

        public SnakeGame()
        {
            form = new RenderForm("Snake");
            form.ClientSize = new System.Drawing.Size(Constants.SCREEN_SIZE * Constants.SPRITE_SIZE, Constants.SCREEN_SIZE * Constants.SPRITE_SIZE / 2);
            form.AllowUserResizing = false;
        }

        public void Dispose()
        {
            renderView.Dispose();
            backBuffer.Dispose();
            device.ImmediateContext.ClearState();
            device.ImmediateContext.Flush();
            device.Dispose();
            swapChain.Dispose();
            factory.Dispose();

            form.Dispose();
        }


        public void Run()
        {
            Initialize();
            RenderLoop.Run(form, RenderCallback);

        }

        private void RenderCallback()
        {

            if (sleeping) return;
            stopwatch = Stopwatch.StartNew();
            Update();
            //Draw();


            if (snakehp.hp > 0 && snake2hp.hp > 0 && snakescore.score < 100 && snake2score.score < 100) Draw();
            else if (snakescore.score >= 100 || snake2hp.hp <= 0) Win("Player1");
            else if (snake2score.score >= 100 || snakehp.hp <= 0) Win("Player2");

            stopwatch.Stop();
            var sleepTime = (int)(1000f / Constants.FRAMES_PER_SECOND - stopwatch.ElapsedMilliseconds);
            if (sleepTime > 0)
            {
                sleeping = true;
                System.Threading.Thread.Sleep(sleepTime);
                sleeping = false;
            }

        }



        protected void Initialize()
        {
            apple = new Fruits1() { x = 13, y = 3 };
            apple2 = new Fruits2() { x = 48, y = 3 };
            snake = new Snake() { x = 12, y = 12, dy = 1 };
            snake2 = new Snake2() { x = 47, y = 12, dy = 1 };


            hp = new HealthBar() { x = 0, y = 26 };

            map = new Map() { x = 1, y = 1, height = 1, width = Constants.SPRITE_SIZE };

            text = new Text(form);

            rng = new Random();
            rnd = new Random(2);

            hpfruit = new Fruits1() { x = 100, y = 100 };
            scorefruit = new Fruits1() { x = 5, y = 5 };
            speedfruit = new Fruits1() { x = 100, y = 100 };

            hp2fruit = new Fruits2() { x = 100, y = 100 };
            score2fruit = new Fruits2() { x = 48, y = 5 };
            speed2fruit = new Fruits2() { x = 100, y = 100 };


            // SwapChain description
            var desc = new SwapChainDescription()
            {
                BufferCount = 1,
                ModeDescription =
                                   new ModeDescription(form.ClientSize.Width, form.ClientSize.Height,
                                                       new Rational(Constants.FRAMES_PER_SECOND, 1), Format.R8G8B8A8_UNorm),
                IsWindowed = true,
                OutputHandle = form.Handle,
                SampleDescription = new SampleDescription(1, 0),
                //SwapEffect = SwapEffect.Discard,
                Usage = Usage.RenderTargetOutput
            };

            // Create Device and SwapChain
            Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.BgraSupport, new SharpDX.Direct3D.FeatureLevel[] { SharpDX.Direct3D.FeatureLevel.Level_10_0 }, desc, out device, out swapChain);

            d2dFactory = new SharpDX.Direct2D1.Factory();


            // Ignore all windows events
            factory = swapChain.GetParent<Factory>();
            factory.MakeWindowAssociation(form.Handle, WindowAssociationFlags.IgnoreAll);

            // New RenderTargetView from the backbuffer
            backBuffer = Texture2D.FromSwapChain<Texture2D>(swapChain, 0);
            renderView = new RenderTargetView(device, backBuffer);

            Surface surface = backBuffer.QueryInterface<Surface>();

            d2dRenderTarget = new RenderTarget(d2dFactory, surface, new RenderTargetProperties(new PixelFormat(Format.Unknown, AlphaMode.Premultiplied)));


            snakescore = new SnakeStats();
            snakehp = new SnakeStats();
            snakespeed = new SnakeStats();

            snake2score = new Snake2Stats();
            snake2hp = new Snake2Stats();
            snake2speed = new Snake2Stats();


            snake.init();
            snake2.init();

            apple.Initialize(d2dRenderTarget, red);
            apple2.Initialize(d2dRenderTarget, red);
            snake.Initialize(d2dRenderTarget, green);
            snake2.Initialize(d2dRenderTarget, Color.DarkOliveGreen);

            hp.Initialize(d2dRenderTarget, red);

            map.Initialize(d2dRenderTarget, Color.Black);


            hpfruit.Initialize(d2dRenderTarget, red);
            scorefruit.Initialize(d2dRenderTarget, Color.PowderBlue);
            speedfruit.Initialize(d2dRenderTarget, Color.Purple);

            hp2fruit.Initialize(d2dRenderTarget, red);
            score2fruit.Initialize(d2dRenderTarget, Color.PowderBlue);
            speed2fruit.Initialize(d2dRenderTarget, Color.Purple);
        }

        protected void Update()
        {

            if (snake.HandleInput())
            {
                form.Close();
                
            }
            snake.HandleInput();
            snake2.HandleInput();

            if (frame % snakespeed.speed == 0)
            {
                snake.Update();
                if (snake.death)
                {
                    snakehp.hp--;
                }
                snake.HandleInput();
            }
            if (frame % snake2speed.speed == 0)
            {
                snake2.Update();
                if (snake2.death)
                {
                    snake2hp.hp--;
                }
                snake2.HandleInput();
            }
            frame++;

            if (eatBonus)
            {
                bonusTime++;
            }
            if (eat2Bonus)
            {
                bonus2Time++;
            }



            dice = rnd.Next(0, 10);
            dice2 = rng.Next(0, 10);

            //----------------Player1--------------------\\
            if (snake.CheckCollision(scorefruit.x, scorefruit.y))
            {
                snakescore = new ScoreBonus(snakescore);
                snake.tail++;

                scorefruit.generateFruit(1);

            }
            if (snake.CheckCollision(hpfruit.x, hpfruit.y))
            {
                snakehp = new HpBonus(snakehp);
                snakescore = new ScoreBonus(snakescore);
                snake.tail++;
                hpfruit.generateFruit(4);


                bonusflag = false;

                eatBonus = true;
            }

            if (snake.CheckCollision(speedfruit.x, speedfruit.y))
            {
                snakescore = new ScoreBonus(snakescore);
                snakespeed = new SpeedBonus(snakespeed);
                snake.tail++;
                speedfruit.generateFruit(4);
                speed = true;


                bonusflag = false;

                eatBonus = true;
            }

            if (dice <= 3 && !bonusflag && bonusTime == Constants.COUNTDOWN)
            {
                hpfruit.generateFruit(2);
                bonusflag = true;
                eatBonus = false;
                bonusTime = 0;
            }

            if (dice > 3 && !bonusflag && !speed && bonusTime == Constants.COUNTDOWN)
            {
                speedfruit.generateFruit(3);
                bonusflag = true;
                eatBonus = false;
                bonusTime = 0;
            }

            if (speed)
            {
                speedFrame++;
                if (speedFrame == Constants.SPEEDTIME)
                {
                    speed = false;
                    snakespeed.speed = Constants.SPEED;
                    speedFrame = 0;
                    bonusTime = 0;
                }
            }


            //----------------Player2------------------\\
            if (snake2.CheckCollision(score2fruit.x, score2fruit.y))
            {
                snake2score = new ScoreBonus(snake2score);
                snake2.tail++;
                score2fruit.generateFruit(1);

            }
            if (snake2.CheckCollision(hp2fruit.x, hp2fruit.y))
            {
                snake2hp = new HpBonus(snake2hp);
                snake2score = new ScoreBonus(snake2score);
                snake2.tail++;
                hp2fruit.generateFruit(4);
                bonus2flag = false;

                eat2Bonus = true;
            }

            if (snake2.CheckCollision(speed2fruit.x, speed2fruit.y))
            {
                snake2score = new ScoreBonus(snake2score);
                snake2speed = new SpeedBonus(snake2speed);
                snake2.tail++;
                speed2 = true;
                speed2fruit.generateFruit(4);
                bonus2flag = false;

                eat2Bonus = true;
            }
            if (dice2 <= 3 && !bonus2flag && bonus2Time == Constants.COUNTDOWN)
            {
                hp2fruit.generateFruit(2);
                bonus2flag = true;
                eat2Bonus = false;
                bonus2Time = 0;
            }
            if (dice2 > 3 && !bonus2flag && !speed2 && bonus2Time == Constants.COUNTDOWN)
            {
                speed2fruit.generateFruit(3);
                bonus2flag = true;
                bonus2Time = 0;
                eat2Bonus = false;
            }

            if (speed2)
            {
                speed2Frame++;
                if (speed2Frame == Constants.SPEEDTIME)
                {
                    speed2 = false;
                    snake2speed.speed = Constants.SPEED;
                    speed2Frame = 0;
                    bonus2Time = 0;
                }
            }


        }


        protected void Draw()
        {



            d2dRenderTarget.BeginDraw();
            d2dRenderTarget.Clear(Color.White);

            d2dRenderTarget.DrawText("Score", text.TextFormatStats, new RectangleF(870, 1, 100, 100), new SolidColorBrush(d2dRenderTarget, Color.Black));
            d2dRenderTarget.DrawText($"{snakescore.score}", text.TextFormatStats, new RectangleF(775, 100, 100, 100), new SolidColorBrush(d2dRenderTarget, Color.Black));
            d2dRenderTarget.DrawText($"{snake2score.score}", text.TextFormatStats, new RectangleF(975, 100, 100, 100), new SolidColorBrush(d2dRenderTarget, Color.Black));


            //apple.Draw(d2dRenderTarget, d2dFactory);
            //apple2.Draw(d2dRenderTarget, d2dFactory);
            snake.Draw(d2dRenderTarget, d2dFactory);
            snake2.Draw(d2dRenderTarget, d2dFactory);
            for (int i = 0; i < snakehp.hp; i++)
            {
                hp.Draw(d2dRenderTarget, d2dFactory, 30 + Constants.SPRITE_SIZE * i, Constants.SPRITE_SIZE * 26);
            }
            for (int i = 0; i < snake2hp.hp; i++)
            {
                hp.Draw(d2dRenderTarget, d2dFactory, 1020 + Constants.SPRITE_SIZE * i, Constants.SPRITE_SIZE * 26);
            }

            map.generateMAP(d2dRenderTarget, d2dFactory, 1);
            map.generateMAP(d2dRenderTarget, d2dFactory, 2);


            scorefruit.Draw(d2dRenderTarget, d2dFactory);
            hpfruit.Draw(d2dRenderTarget, d2dFactory);
            speedfruit.Draw(d2dRenderTarget, d2dFactory);


            score2fruit.Draw(d2dRenderTarget, d2dFactory);
            hp2fruit.Draw(d2dRenderTarget, d2dFactory);
            speed2fruit.Draw(d2dRenderTarget, d2dFactory);

            d2dRenderTarget.EndDraw();
            swapChain.Present(0, PresentFlags.None);
        }



        private void Win(string player)
        {
            d2dRenderTarget.BeginDraw();
            d2dRenderTarget.Clear(Color.White);
            d2dRenderTarget.DrawText($"{player} win", new TextFormat(new SharpDX.DirectWrite.Factory(), "Calibri", 40), new RectangleF(700, 400, 300, 300), new SolidColorBrush(d2dRenderTarget, Color.Black));
            d2dRenderTarget.DrawText($"Press Esc to restart", new TextFormat(new SharpDX.DirectWrite.Factory(), "Calibri", 40), new RectangleF(650, 700, 600, 300), new SolidColorBrush(d2dRenderTarget, Color.Black));
            d2dRenderTarget.EndDraw();
            swapChain.Present(0, PresentFlags.None);
        }
    }
}