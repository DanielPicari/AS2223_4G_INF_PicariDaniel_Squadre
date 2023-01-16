using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            // TODO U.1
            Assert.IsTrue(Players.count>15);
            
        }

        [Test]
        public void AddCaptain()
        {
            // TODO U.2
            Assert.IsTrue(captain.count==1);
        }
    }
}