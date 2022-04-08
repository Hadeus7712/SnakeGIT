namespace SnakeGIT
{
    public class HpBonus : Decorator
    {
        public HpBonus(Stats stats) : base(stats.hp, stats.score, stats.speed)
        {
            SetStats();
        }
        public override void SetStats()
        {
            hp++;
        }
    }

}
