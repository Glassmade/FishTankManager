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
    public class PetFishTest
    {
        
        private PetFish _testPetGoldFish, _testPetBabelFish;

        [SetUp]
        public void SetUp()
        {
            _testPetGoldFish = new PetFish("George", "GOLD");
            _testPetBabelFish = new PetFish("Michael", "Babel");
        }

        [Test]
        public void TestThaPetFishCanBeInstantiated()
        {
            Assert.That(_testPetGoldFish, Is.Not.Null);
        }

        [Test]
        public void TestPetFishCanHaveItsNameAccessed()
        {
            Assert.That(_testPetGoldFish.PetFishNameAccess, Is.EqualTo("George"));
        }

        [Test]
        public void TestPetFishCanHaveItsWeightAccessed()
        {
            Assert.That(_testPetGoldFish.PetFishWeightAccess, Is.EqualTo(0.1f));
        }

        [Test]
        public void TestPetFishCanHaveItsTypeAccessed()
        {
            Assert.That(_testPetGoldFish.PetFishTypeAccess, Is.EqualTo("GOLD"));
        }

        [Test]
        public void TestPetFishCanHaveItsTypeAccessedEvenIfUserProvidesMixedCaseTypeForFish()
        {
            Assert.That(_testPetBabelFish.PetFishTypeAccess, Is.EqualTo("BABEL"));
        }

        [Test]
        public void TestPetFishesAreNotEqualsWhenDifferentTypesOrNamesWhereGiven()
        {
            Assert.That(_testPetBabelFish, Is.Not.EqualTo(_testPetGoldFish));
        }

        [Test]
        public void TestPetFishesAreEqualsWhenSameTypesAndNamesWhereGiven()
        {
            Assert.That(_testPetGoldFish, Is.EqualTo(_testPetGoldFish));
        }

    }

}
