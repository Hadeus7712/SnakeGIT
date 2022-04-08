namespace SnakeGIT
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

}
