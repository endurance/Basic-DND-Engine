using DnDEngine.Characters;
using DnDEngine.Characters.Age;
using DnDEngine.Characters.Races;
using Moq;
using NUnit.Framework;

namespace DnDEngineTester.Character.Age
{
    [TestFixture]
    public class AgeEffectTester
    {
        [Test]
        public void Middle_Age_Effect_Returns()
        {
            int age = 20;
            var charMock = new Mock<ICharacter>();
            var raceMock = new Mock<IRace>();
            raceMock.Setup(i => i.GetAgeStatus(age)).Returns(AgeStatus.MiddleAge);
            charMock.Setup(i => i.Age).Returns(age);
            charMock.Setup(i => i.Race).Returns(raceMock.Object);
            var character = charMock.Object;

            AgeEffectService service = new AgeEffectService();
            var stats = service.CalculateAgeEffects(character);

            Assert.IsTrue(stats != null);
        }
    }
}
