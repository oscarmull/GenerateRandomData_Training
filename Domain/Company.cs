using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attributter;

namespace Domain
{
    public class Company
    {
        [SingleFieldMetadata("GenerateRandomCompanyName", typeof(Infrastracture.Randomizers.Enterprise))]
        public string CompanyName { get; set; }

        [SingleFieldMetadata("GenerateRandomSingleLineObjective", typeof(Infrastracture.Randomizers.Enterprise))]
        public string CompanyObjective { get; set; }

        [SingleFieldMetadata("GenerateRandomDateBewtweenTwoYears", typeof(Infrastracture.Randomizers.DateGen),1990,2010)]
        public DateTime StartDate { get; set; }

        [SingleFieldMetadata("GenerateRandomURL", typeof(Infrastracture.Randomizers.Internet))]
        public string URL { get; set; }

        [SingleFieldMetadata("GenerateRandomCompanyPhrase", typeof(Infrastracture.Randomizers.Enterprise))]
        public string CompanyMotto { get; set; }

        [SingleFieldMetadata("GenerateRandomURL", typeof(Infrastracture.Randomizers.Internet))]
        public string LogoURL { get; set; }

        [ListMetadata(1,3,typeof(Domain.Address))]
        public List<Domain.Address> Addresses { get; set; }

        [ListMetadata(0,6, typeof(Domain.Contact))]
        public List<Domain.Contact> Contacts { get; set; }

        public Company() {
            this.Addresses = new List<Domain.Address>(); 
        }
    }
}
