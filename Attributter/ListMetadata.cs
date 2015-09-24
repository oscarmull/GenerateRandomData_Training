using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributter
{
    [AttributeUsage(AttributeTargets.All)]
    public class ListMetadata:System.Attribute
    {
        public int MaxNumberOfElements { get; set; }
        public int MinNumberOfElements { get; set; }
        public Object TypeOfElement { get; set; }
        public object[] RandomizerParameters { get; set; }
        public bool RandomNumberElements { get; set; }

        public ListMetadata(int minNumElements, int maxNumElements, Object ElementsType, params object[] param)
        {
            this.MaxNumberOfElements = maxNumElements;
            this.MinNumberOfElements = minNumElements;
            this.TypeOfElement = ElementsType;
            this.RandomizerParameters = param;
        }

    }
}
