using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTankManager.Models
{
    public class PetFish
    {
        private String _petFishName;
        private String _petFishType;
        private float _petFishWeight;
        private Dictionary<string, float> _petFishTypes;
        
        public PetFish(String inputtedPetFishName, String inputtedPetFishType)
        {
            _petFishTypes = populateExistingFishTypes();
            _petFishName = inputtedPetFishName;
            _petFishWeight = returnFishTypesWeight(inputtedPetFishType.ToUpper());
            _petFishType = inputtedPetFishType.ToUpper();

        }

        private Dictionary<String, float> populateExistingFishTypes()
        {
            Dictionary<string, float> tempFishTypes = new Dictionary<string, float>();
            tempFishTypes.Add("GOLD", 0.1f);
            tempFishTypes.Add("ANGEL", 0.2f);
            tempFishTypes.Add("BABEL", 0.3f);
            return tempFishTypes;
        }

        private float returnFishTypesWeight(String inputtedFishType)
        {
            float tempFloat = 0;
            try
            {
                tempFloat = _petFishTypes[inputtedFishType];
            }
            catch (ArgumentException invalidArgumentException)
            {
                Console.Write("We can only provide the following fish species Gold,Angel,Babel " + invalidArgumentException);
            }
            return tempFloat;
        }
   
        public String PetFishNameAccess
        {
            get { return _petFishName; }   
            set { _petFishName = value; }
        }

        public String PetFishTypeAccess
        {
            get { return _petFishType; }
        }

        public float PetFishWeightAccess
        {
            get { return _petFishWeight; } 
        }

        public Dictionary<string, float> PetFishTypesAccess
        {
            get { return _petFishTypes; }
        }

    }
}
