using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FishTankManager.Models;

namespace FishTankManager.Tests.Services
{
    [TestFixture]
    public class FishTankServiceTest
    {

        private PetFish _testPetGoldFish, _testPetBabelFish;
        private PetFishTank _testPetFishTank;
        private ManagerRunner _testManagerRunner;

        [SetUp]
        public void SetUp()
        {
            _testPetGoldFish = new PetFish("George", "GOLD");
            _testPetBabelFish = new PetFish("Michael", "Babel");
            List<PetFish> _testPetFishTankPopulation = new List<PetFish>();
            _testPetFishTankPopulation.Add(_testPetGoldFish);
            _testPetFishTankPopulation.Add(_testPetBabelFish);
            _testPetFishTank = new PetFishTank(_testPetFishTankPopulation);
            _testManagerRunner = new ManagerRunner(_testPetFishTank);

        }

        [Test]
        public void testThatCanGetTheAppropriateFoodWeighForMyPetFishes()
        {
            Assert.That("0.4", Is.EqualTo(_testManagerRunner.provideAppriateFoodForFishInTank()));
        }

    }
}
