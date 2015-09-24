using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Property
    {
        

        public string GenerateRandomPropertyBuildingStatus(){
            List<string> buildingStatus = new List<string>();
            buildingStatus.Add("Existing");
            buildingStatus.Add("Under Construction");
            buildingStatus.Add("Demolished");
            buildingStatus.Add("Under Renovation");
            buildingStatus.Add("Converted");
            buildingStatus.Add("Proposed");
            return buildingStatus[Randomizer.Number.RandomIntMinMax(0,buildingStatus.Count)];
        }
    }
}
