using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FishTankManager.Models;

namespace FishTankManager.Tests.Models
{
    [TestFixture]
    public class PetFishTankTest
    {

        private PetFish _testPetGoldFish, _testPetBabelFish;
        private PetFishTank _testPetFishTank;

        [SetUp]
        public void SetUp()
        {
            _testPetGoldFish = new PetFish("George", "GOLD");
            _testPetBabelFish = new PetFish("Michael", "Babel");
            List<PetFish> _testPetFishTankPopulation = new List<PetFish>();
            _testPetFishTankPopulation.Add(_testPetGoldFish);
            _testPetFishTankPopulation.Add(_testPetBabelFish);
            _testPetFishTank = new PetFishTank(_testPetFishTankPopulation);
        }

        [Test]
        public void TestThaPetFishTankCanBeInstantiated()
        {
            Assert.That(_testPetFishTank, Is.Not.Null);
        }
    }
}
