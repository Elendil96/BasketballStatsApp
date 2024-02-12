using static BasketballStatsApp.PlayerBase;

namespace BasketballStatsApp
{
    public interface IPlayer
    {
        public string Name { get; }

        public string Surname { get; }

        public string Club { get; }

        void AddScore(int score);

        void AddScore(string score);

        Statistics GetStatistics();

        event ScoreAddedDelegate ScoreAdded;
    }
}
