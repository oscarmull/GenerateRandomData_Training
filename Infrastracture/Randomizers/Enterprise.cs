using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Enterprise
    {
        public string GenerateRandomSingleLineObjective()
        {
            return Faker.Company.BS();
        }
        public string GenerateRandomCompanyPhrase()
        {
            return Faker.Company.CatchPhrase();
        }
        public string GenerateRandomCompanyName()
        {
            return Faker.Company.Name();
        }
        public string GenerateRandomCompanyNameSuffix()
        {
            return Faker.Company.Suffix();
        }
        public string GenerateRandomPhone()
        {
            return Faker.Phone.Number();
        }
    }
}
