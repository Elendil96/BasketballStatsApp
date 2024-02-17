using BasketballStatsApp;

namespace BasketballStatssApp.Test
{
    public class PlayerTests
    {
        [Test]
        public void PlayerCollectsScores_ShouldReturnCorrectScore()
        {
            var player = new PlayerInMemory("Micha³", "Banan", "Ruch Bielszowice");

            player.AddScore(6);
            player.AddScore(84);
            player.AddScore(30);
            player.AddScore("B");
            player.AddScore("a");

            var result = player.GetStatistics();

            Assert.AreEqual(100, result.Max);
            Assert.AreEqual(6, result.Min);
            Assert.AreEqual(60, result.Average);
            Assert.AreEqual('B', result.AverageLetter);
            Assert.AreEqual(300, result.Sum);
            Assert.AreEqual(5, result.Count);
        }
    }
}