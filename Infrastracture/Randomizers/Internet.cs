using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Internet
    {
        public string GenerateRandomDomainName() { 
            return Faker.Internet.DomainName();
        }
        public string GenerateRandomDomainType() {
            return Faker.Internet.DomainSuffix();
        }
        public string GenerateRandomUserName() {
            return Faker.Internet.UserName();
        }
        public string GenerateRandomUserNameForName(string name) {
            return Faker.Internet.UserName(name);
        }
        public string GenerateRandomURL() {
            return Faker.InternetFaker.Url();
        }
        public string GenerateRandomAlphanumeric(int length)
        {
            return Faker.StringFaker.AlphaNumeric(length);
        }
    }
}
