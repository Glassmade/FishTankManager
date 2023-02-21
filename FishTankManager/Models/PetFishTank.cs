using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTankManager.Models
{
    public class PetFishTank
    {
        private List<PetFish> _petFishInTank;

        public PetFishTank(List<PetFish> inputtedPetFishPopulation)
        {
            _petFishInTank = inputtedPetFishPopulation;
        }

        public List<PetFish> PetFishTankAccess
        {
            get { return _petFishInTank; }
            set { _petFishInTank = value;}
        }
    
    }
}
