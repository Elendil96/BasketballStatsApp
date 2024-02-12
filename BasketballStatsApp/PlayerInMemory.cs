namespace BasketballStatsApp
{
    public class PlayerInMemory : PlayerBase
    {

        private List<int> scores = new List<int>();

        public PlayerInMemory(string name, string surname, string club) 
            : base(name, surname, club)
        {
        }

        public override event ScoreAddedDelegate ScoreAdded;

        public override void AddScore(int score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);

                if (ScoreAdded != null)
                {
                    ScoreAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"{score} - Invalid grade value");
            }
        }

        public override void AddScore(string score)
        {
            if (int.TryParse(score, out int result))
            {
                this.AddScore(result);
            }
            else if (char.TryParse(score, out char resultChar))
            {
                switch (resultChar)
                {
                    case 'A':
                    case 'a':
                        this.AddScore(100);
                        break;
                    case 'B':
                    case 'b':
                        this.AddScore(80);
                        break;
                    case 'C':
                    case 'c':
                        this.AddScore(60);
                        break;
                    case 'D':
                    case 'd':
                        this.AddScore(40);
                        break;
                    case 'E':
                    case 'e':
                        this.AddScore(20);
                        break;
                    default:
                        throw new Exception($"{score} - Wrong letter");
                }
            }
            else
            {
                throw new Exception($"{score} - String in not int");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.scores)
            {
                statistics.AddScore(grade);
            }

            return statistics;
        }
    }
}
