namespace SnakeGIT
{
    public abstract class Decorator : Stats
    {
        protected Stats stats;
        public Decorator(int hp, int score, int speed) : base(hp, score, speed)
        {
            this.hp = hp;
            this.score = score;
            this.speed = speed;
        }
        public override void SetStats()
        {
            if (stats != null) stats.SetStats();
        }
    }

}
