using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attributter;
using Infrastracture.Randomizers;

namespace Domain
{
    [DebuggerDisplay("{FullAddress} a {Country}")]
    public class Address
    {
        [SingleFieldMetadata("GenerateRandomFullUSAddress", typeof(Infrastracture.Randomizers.Address))]
        public string FullAddress { get; set; }
        [SingleFieldMetadata("GenerateRandomCountryCode",typeof(Infrastracture.Randomizers.Address))]
        public string Country { get; set; }
        [SingleFieldMetadata("GenerateRamdonWord", typeof(Infrastracture.Randomizers.Text))]
        public string Suite { get; set; }
    }
}
