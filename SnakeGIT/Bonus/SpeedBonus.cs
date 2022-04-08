namespace SnakeGIT
{
    public class SpeedBonus : Decorator
    {

        public SpeedBonus(Stats stats) : base(stats.hp,stats.score, stats.speed)
        {
            SetStats();
        }
        public override void SetStats()
        {
            speed = 2;
        }
    }

}
