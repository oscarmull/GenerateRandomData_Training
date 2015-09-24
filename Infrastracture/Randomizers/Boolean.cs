using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Boolean
    {
        public bool GenerateRandomBool() {
            return Faker.BooleanFaker.Boolean();
        }
    }
}
