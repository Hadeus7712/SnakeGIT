﻿namespace SnakeGIT
{
    public abstract class Stats
    {
        public Stats(int hp, int score, int speed) 
        {
            this.hp = hp;
            this.score = score;
            this.speed = speed;
        }
        public int hp { get; set; }
        public int score { get; set; }
        public int speed { get; set; }
        public abstract void SetStats();

    }

    public class SnakeStats : Stats
    {
        public SnakeStats() : base(Constants.HP, 0 , 6)
        {
            SetStats();
        }

        public override void SetStats()
        {
            hp = Constants.HP;
            speed = 3;
            score = 1;
        }
    }

    public class Snake2Stats : Stats
    {
        public Snake2Stats() : base(Constants.HP, 0, 6)
        {

        }
        public override void SetStats()
        {
            hp = Constants.HP;
            speed = 3;
            score = 0;
        }
    }

    public abstract class Decorator : Stats
    {
        protected Stats stats;
        public Decorator(int hp, int score, int speed) : base(hp, score, speed)
        {
            this.hp = hp;
            this.score = score;
            this.speed = speed;
        }
        
    }

    public class HpBonus : Decorator
    {
        public HpBonus(Stats stats) : base(stats.hp + 1, stats.score, stats.speed)
        {

        }
        public override void SetStats()
        {
            hp++;
        }
    }

    public class ScoreBonus : Decorator
    {
        public ScoreBonus(Stats stats) : base(stats.hp, stats.score, stats.speed)
        {
            SetStats();
        }
        public override void SetStats()
        {
             score++;
        }
    }

    public class SpeedBonus : Decorator
    {

        public SpeedBonus(Stats stats) : base(stats.hp,stats.score, stats.speed - 2)
        {

        }
        public override void SetStats()
        {
            speed -= 2;
        }
    }

}
