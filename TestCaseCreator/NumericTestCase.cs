using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestCaseCreator
{
    public class NumericTestCase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FieldUnderTest { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public string Value { get; set; }
        public string ExpectedValue { get; set; }
        public string TypeOfTestCase { get; set; }
        public string ExclusionReason { get; set; }
        public bool IsValid { get; set; }

      public NumericTestCase(string fieldUnderTest){
          this.FieldUnderTest = fieldUnderTest;
          this.IsValid = true;
      }

        public string jsonizeme() {
            return JsonConvert.SerializeObject(this);
        }
        
    }
}
