namespace Nancy.Simple
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TestPokerPlayer
    {
        [Test]
        public void TestPokerPlayerFolds()
        {
            Assert.AreEqual(0, PokerPlayer.BetRequest(new Game()));
        }
    }
}
