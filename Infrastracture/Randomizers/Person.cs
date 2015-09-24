using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Person
    {

        public string GenerateRandomFirstName()
        {
            bool isMale = Randomizer.Boolean.GenerateRandomBool();
            if (!isMale) {
                return Faker.NameFaker.FemaleFirstName();
            }
            return Faker.NameFaker.MaleFirstName();
        }
        public string GenerateRandomLastName()
        {
            return Faker.Name.Last();
        }
        public string GenerateRandomFullName(bool isMale = true)
        {
            if (!isMale)
            {
                return Faker.NameFaker.FemaleName();
            }
            return Faker.NameFaker.MaleName();
        }
        public string GenerateRandomSuffixForName()
        {
            return Faker.Name.Suffix();
        }
        public string GenerateRandomPrefixForName()
        {
            return Faker.Name.Prefix();
        }
        public string GenerateRandomEmail() {
            return Faker.Internet.Email();
        }
        public string GenerateRandomEmailForName(string name)
        {
            return Faker.Internet.Email(name);
        }
        public string GenerateRandomPhone(string culture = "en-us") {
            if (!culture.ToUpper().Equals("en-us")) {
                return Faker.PhoneFaker.InternationalPhone();
            }
            return Faker.Phone.Number();
        }
        public string GenerateRandomPassword(int length) {
            return Faker.StringFaker.AlphaNumeric(length);
        }
    }
}
