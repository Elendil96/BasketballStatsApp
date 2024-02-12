namespace BasketballStatsApp
{
    public abstract class PlayerBase : IPlayer
    {
        public PlayerBase(string name, string surname, string club)
        {
            this.Name = name;
            this.Surname = surname;
            this.Club = club;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Club { get; private set; }

        public abstract void AddScore(int score);

        public abstract void AddScore(string score);

        public abstract Statistics GetStatistics();


        public delegate void ScoreAddedDelegate(object sender, EventArgs args);


        public abstract event ScoreAddedDelegate ScoreAdded;
    }
}
