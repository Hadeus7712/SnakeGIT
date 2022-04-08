namespace SnakeGIT
{
    public class ScoreBonus : Decorator
    {
        public ScoreBonus(Stats stats) : base(stats.hp, stats.score+1, stats.speed)
        {
            //SetStats();
        }
        public override void SetStats()
        {
             score++;
        }
    }

}
