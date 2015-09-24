using Attributter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastracture.Randomizers;

namespace Domain
{
    public class Contact
    {
        [SingleFieldMetadata("GenerateRandomFirstName", typeof(Infrastracture.Randomizers.Person))]
        public string FirstName { get; set; }
        [SingleFieldMetadata("GenerateRandomLastName", typeof(Infrastracture.Randomizers.Person))]
        public string LastName { get; set; }
        [SingleFieldMetadata("GenerateRandomBirthdateMinAge", typeof(Infrastracture.Randomizers.DateGen), 18)]
        public DateTime BirthDate { get; set; }
        [SingleFieldMetadata("GenerateRandomEmail", typeof(Infrastracture.Randomizers.Person))]
        public string EmailAddress { get; set; }
        [SingleFieldMetadata("GenerateRandomPhone", typeof(Infrastracture.Randomizers.Person),"en-us")]
        public string PhoneNumber { get; set; }
    }
}
