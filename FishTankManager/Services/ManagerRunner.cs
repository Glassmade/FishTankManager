using FishTankManager.Models;
using System.Diagnostics.Metrics;

namespace FishTankManager
{
    public class ManagerRunner
    {
        private static PetFishTank _managedPetFishTank;
      
        public ManagerRunner(PetFishTank inputtedPetFishTank)
        {
            _managedPetFishTank = inputtedPetFishTank;
        }
        public void Main(String[] arguments)
        {
            int counter = 1;
            List<PetFish> petFishPopulation = new List<PetFish>();

            Boolean stopFlag = false;
            do
            {

                Console.WriteLine("Pet fish number #" + counter);
                Console.WriteLine("Enter your pet fish's name:");

                String petFishName = tryReadOrThrowException();
                Console.WriteLine("Enter your pet fish's type: Gold,Angel or Babel");
                String petFishType = tryReadOrThrowException();
                petFishPopulation.Add(new PetFish(petFishName, petFishType));
                Console.WriteLine("Do you have more fishes to add to the tank? (y/n)");

                counter++;
                if (tryReadOrThrowException().ToLower() == "n")
                    stopFlag = true;

            } while (stopFlag);

            _managedPetFishTank = new PetFishTank(petFishPopulation);
            Console.Write("The amount of food you should give for your fish population is: " +
                provideAppriateFoodForFishInTank() + " gramms!");
        }

        private  String tryReadOrThrowException()
        {
            String usersRead = null;
            try
            {
                usersRead = Console.ReadLine();
            }
            catch (Exception multiPossibleExceptions)
            {
                Console.WriteLine(multiPossibleExceptions.Message);
            }
            return usersRead;
        }

        // Renamed it from feed()
        public  String provideAppriateFoodForFishInTank()
        {
            float totalFoodWeight = 0;
           foreach (PetFish petFish in _managedPetFishTank.PetFishTankAccess)
            {
                totalFoodWeight += petFish.PetFishWeightAccess;
            }
           return totalFoodWeight.ToString();
        }

    }
}