namespace SnakeGIT
{
    public class SnakeStats : Stats
    {
        public SnakeStats() : base(Constants.HP, 0 , 6)
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
