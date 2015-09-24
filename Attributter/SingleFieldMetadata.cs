using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Attributter
{
    [AttributeUsage(AttributeTargets.All)]
    public class SingleFieldMetadata:System.Attribute
    {
        public string SpecificRandomizer { get; set; }
        public Object TypeOfRandomizer { get; set; }
        public object[] RandomizerParameters { get; set; }

        public SingleFieldMetadata(string specificProperty,Object randomizerType,params object[] param) {
            this.SpecificRandomizer = specificProperty;
            this.TypeOfRandomizer = randomizerType;
            this.RandomizerParameters = param;
        }
        
    }
}
