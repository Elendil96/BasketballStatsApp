using BasketballStatsApp;

namespace BasketballStatssApp.Test
{
    public class TypeTests
    {
        [Test]
        public void GetPlayerReturnsDifferentObjects()
        {
            var player1 = GetPlayer("Micha³", "Banan", "Ruch Bielszowice");
            var player2 = GetPlayer("Arek", "Michalski", "Sparta Wolczyce");

            Assert.AreNotSame(player1, player2);
            Assert.False(player1.Equals(player2));
            Assert.False(Object.ReferenceEquals(player1, player2));
        }

        [Test]
        public void TwoVarsCanReferenceSameObject()
        {
            var player1 = GetPlayer("Micha³", "Banan", "Ruch Bielszowice");
            var player2 = player1;

            Assert.AreSame(player1, player2);
            Assert.True(player1.Equals(player2));
            Assert.True(Object.ReferenceEquals(player1, player2));
        }

        private PlayerInMemory GetPlayer(string name, string surname, string club)
        {
            return new PlayerInMemory(name, surname, club);
        }
    }
}
