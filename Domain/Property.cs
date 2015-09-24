using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain
{
    public class Property
    {
        public int PropertyID { get; set; }
        public string CountryCode { get; set; }
        public string ConstructionStatus { get; set; }
        public List<Address> Addresses { get; set; }

        public Property() {
            this.Addresses = new List<Address>();
        }

        public string jsonizeme()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
