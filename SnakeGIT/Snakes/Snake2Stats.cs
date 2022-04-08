namespace SnakeGIT
{
    public class Snake2Stats : Stats
    {
        public Snake2Stats() : base(Constants.HP, 0, 6)
        {
            SetStats();
        }
        public override void SetStats()
        {
            hp = Constants.HP;
            speed = Constants.SPEED;
            score = 0;
        }
    }

}
