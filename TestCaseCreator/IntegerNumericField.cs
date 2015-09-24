using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastracture.Randomizers;

namespace TestCaseCreator
{
    public class IntegerNumericField
    {
        //example field: Asking Rent
        
        public int MinValidValue { get; set; }
        public int MaxValidValue { get; set; }
        public bool AcceptsNulls { get; set; }
        public string NullReplaceValueString { get; set; }
        public int NullReplaceValueInt { get; set; }
        public bool AcceptsRange { get; set; }
        public List<NumericTestCase> listOfTestCases { get; set; }
        public string FieldName { get; set; }
        public char RangeSeparator { get; set; }
        


        public IntegerNumericField(string name) {
            this.FieldName = name;
            this.listOfTestCases = new List<NumericTestCase>();
        }

       public void GenerateTestCases() {
            this.NullTestCases();
            this.RangeTestCases();

        }

        public void RangeTestCases() {
            var testCase = new NumericTestCase(this.FieldName);
            testCase.Description = "Range";
            testCase.TypeOfTestCase = "Valid - Range";
            testCase.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
            if (this.AcceptsRange)
            {
                if (MinValidValue == MaxValidValue)
                {
                    testCase.ExclusionReason = "Min and Max are the same. No range permitted";
                    testCase.IsValid = false;
                    this.listOfTestCases.Add(testCase);
                }
                else {
                    if (MinValidValue > MaxValidValue)
                    {
                         testCase.ExclusionReason ="Min > Max. No range permitted. Check values again";
                         testCase.IsValid = false;
                         this.listOfTestCases.Add(testCase);
                    }
                    else {
                        var testCaseEqual = new NumericTestCase(this.FieldName);
                        testCaseEqual.Name = String.Format("{0} - {1}",this.FieldName,testCase.Description);
                        testCaseEqual.Description = "Range min = max";
                        testCaseEqual.TypeOfTestCase = "Valid - Range";
                        testCaseEqual.MinValue = Randomizer.Number.GenerateLowerPartOfRange(this.MinValidValue, this.MaxValidValue);
                        testCaseEqual.MaxValue = testCaseEqual.MinValue;
                        testCaseEqual.ExpectedValue = testCaseEqual.MaxValue.ToString();
                        this.listOfTestCases.Add(testCaseEqual);

                        var testCaseMinLTMax = new NumericTestCase(this.FieldName);
                        testCaseMinLTMax.Name = String.Format("{0} - {1}",this.FieldName,testCase.Description);
                        testCaseMinLTMax.Description = "Range min < max";
                        testCaseMinLTMax.TypeOfTestCase = "Valid - Range";
                        testCaseMinLTMax.MinValue = Randomizer.Number.GenerateLowerPartOfRange(this.MinValidValue, this.MaxValidValue);
                        testCaseMinLTMax.MaxValue = Randomizer.Number.RandomIntMinMax(testCaseMinLTMax.MinValue, this.MaxValidValue);
                        testCaseMinLTMax.ExpectedValue = String.Format("{0} {1} {2}", testCaseMinLTMax.MinValue, this.RangeSeparator.ToString(), testCaseMinLTMax.MaxValue);
                        this.listOfTestCases.Add(testCaseMinLTMax);

                        var testCaseMinNNMaxNull = new NumericTestCase(this.FieldName);
                        testCaseMinNNMaxNull.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
                        testCaseMinNNMaxNull.Description = "Range min is not null, max is null";
                        testCaseMinNNMaxNull.TypeOfTestCase = "Valid - Range";
                        testCaseMinNNMaxNull.MinValue = Randomizer.Number.RandomIntMinMax(this.MinValidValue, this.MaxValidValue);
                        testCaseMinNNMaxNull.Value = testCaseMinNNMaxNull.MinValue.ToString();
                        testCaseMinNNMaxNull.ExpectedValue = String.Format("{0}", testCaseMinNNMaxNull.Value);
                        this.listOfTestCases.Add(testCaseMinNNMaxNull);

                        var testCaseMinNullMaxNN = new NumericTestCase(this.FieldName);
                        testCaseMinNullMaxNN.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
                        testCaseMinNullMaxNN.Description = "Range min is null, max is not null";
                        testCaseMinNullMaxNN.TypeOfTestCase = "Valid - Range";
                        testCaseMinNullMaxNN.MaxValue = Randomizer.Number.RandomIntMinMax(testCaseMinNullMaxNN.MinValue, this.MaxValidValue);
                        testCaseMinNullMaxNN.Value = testCaseMinNullMaxNN.MaxValue.ToString();
                        testCaseMinNullMaxNN.ExpectedValue = String.Format("{0}", testCaseMinNullMaxNN.Value);
                        this.listOfTestCases.Add(testCaseMinNullMaxNN);

                        var testCaseBorder = new NumericTestCase(this.FieldName);
                        testCaseBorder.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
                        testCaseBorder.Description = "Borders of the range";
                        testCaseBorder.TypeOfTestCase = "Valid - Range";
                        testCaseBorder.MinValue = this.MinValidValue;
                        testCaseBorder.MaxValue = this.MaxValidValue;
                        testCaseBorder.ExpectedValue = String.Format("{0} {1} {2}", testCaseBorder.MinValue, this.RangeSeparator.ToString(), testCaseBorder.MaxValue);
                        this.listOfTestCases.Add(testCaseBorder);

                        var testCaseOneOffLow = new NumericTestCase(this.FieldName);
                        testCaseOneOffLow.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
                        testCaseOneOffLow.Description = "Borders of the range";
                        testCaseOneOffLow.TypeOfTestCase = "Invalid - Range";
                        testCaseOneOffLow.IsValid = false;
                        testCaseOneOffLow.MinValue = this.MinValidValue - 1;
                        testCaseOneOffLow.MaxValue = this.MaxValidValue;
                        testCaseOneOffLow.ExpectedValue = "Lower value is one below the minimum";
                        this.listOfTestCases.Add(testCaseOneOffLow);

                        var testCaseOneOffHigh = new NumericTestCase(this.FieldName);
                        testCaseOneOffHigh.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
                        testCaseOneOffHigh.Description = "Borders of the range";
                        testCaseOneOffHigh.TypeOfTestCase = "Invalid - Range";
                        testCaseOneOffHigh.IsValid = false;
                        testCaseOneOffHigh.MinValue = this.MinValidValue;
                        testCaseOneOffHigh.MaxValue = this.MaxValidValue + 1;
                        testCaseOneOffHigh.ExpectedValue = "Upper value is one above the maximum";
                        this.listOfTestCases.Add(testCaseOneOffHigh);

                    }
                }
            }
            else {
                testCase.ExclusionReason = "Ranges are not allowed. Not test cases for ranges";
                testCase.IsValid = false;
                this.listOfTestCases.Add(testCase);
            }
        }

        public void AddYourOwnTest(string name, string description, string typeOfTestCase, bool isValid, int minValue, int maxValue, string expectedValue, string exceptionReason) {
            var testCase = new NumericTestCase(name);
        }
       
        
        
        
        public void NullTestCases() {
            var testCase = new NumericTestCase(this.FieldName);
            testCase.Description = "Null Values";
            testCase.TypeOfTestCase = "Null";
            testCase.Value = "Null";
            testCase.Name = String.Format("{0} - {1}", this.FieldName, testCase.Description);
            if (AcceptsNulls)
            {
                testCase.ExpectedValue = "Null";
            }
            else {
                if (!String.IsNullOrEmpty(this.NullReplaceValueString))
                {
                    testCase.ExpectedValue = this.NullReplaceValueString;
                }
                else {
                    testCase.ExpectedValue = this.NullReplaceValueInt.ToString();
                }
            }
            this.listOfTestCases.Add(testCase);
        }

    }
}
