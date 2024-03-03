using System.Xml.Linq;

namespace BasketballStatsApp
{
    public class PlayerInFile : PlayerBase
    {
        private string fileName;
        private string playerName; 
        private string playerSurname;
        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public override event ScoreAddedDelegate ScoreAdded;

        public PlayerInFile(string name, string surname, string club)
            : base(name, surname, club)
        {
            this.playerName = name;
            this.playerSurname = surname;            
            this.fileName = $@"{desktopPath}\{name}_{surname}_Scores.txt";
        }


        public override void AddScore(int score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);

                    if (ScoreAdded != null)
                    {
                        ScoreAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception($"{score} - Invalid score value");
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
            var scoreFromFile = this.ReadScoresFromFile();
            var result = this.CountStatistics(scoreFromFile);
            return result;
        }

        private List<int> ReadScoresFromFile()
        {
            var scores = new List<int>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = int.Parse(line);
                        scores.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }

            return scores;
        }

        private Statistics CountStatistics(List<int> scores)
        {
            var statistics = new Statistics();

            foreach (var score in scores)
            {
                statistics.AddScore(score);
            }

            return statistics;
        }
    }
}

