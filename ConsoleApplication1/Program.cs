using Infrastracture.Randomizers;
using Infrastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCaseCreator;
using Domain;
using FizzWare.NBuilder;
using System.Reflection;
using Newtonsoft.Json;
using Attributter;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var reader = new ObjectRandomizer();
            Domain.Address domObj = new Domain.Address();
            reader.generateObjectRandomData<Domain.Address>(domObj);

            Domain.Company compObj = new Domain.Company();
            reader.generateObjectRandomData<Domain.Company>(compObj);

            
            


            
            var property = Builder<Domain.Property>
                                    .CreateNew()
                                    .With(p => p.ConstructionStatus = Randomizer.Property.GenerateRandomPropertyBuildingStatus())
                                    .And(p => p.CountryCode = Randomizer.Address.GenerateRandomCountryCode())
                                    .And(p=> p.Addresses = (List<Domain.Address>)Builder<Domain.Address>
                                                            .CreateListOfSize(4)
                                                            .All().With(a => a.FullAddress = Randomizer.Address.GenerateRandomAddress())
                                                            .All().With(a => a.Country = Randomizer.Address.GenerateRandomCountry())
                                                            .Random(2).With(a=>a.Suite = Randomizer.Number.RandomIntMinMax(101,505).ToString())
                                                            .Random(2).With(a => a.Suite = null)
                                                            .Build())
                                    .Build();
            int maxElements;
            
            var mockData = Builder<Domain.Property>
                                    .CreateListOfSize(20)
                                    .All().With(p => p.PropertyID = Randomizer.Number.RandomIntMinMax(1, 9999999))
                                          .With(p => p.CountryCode = Randomizer.Address.GenerateRandomCountry())
                                          .With(p => p.Addresses = (List<Domain.Address>)Builder<Domain.Address>
                                                            .CreateListOfSize(Randomizer.Number.RandomIntMinMaxOut(2, 50, out maxElements))
                                                            .All()
                                                                .With(a => a.FullAddress = Randomizer.Address.GenerateRandomAddress())
                                                                .With(a => a.Country = Randomizer.Address.GenerateRandomCountry())
                                                                .Random(Randomizer.Number.RandomIntMinMax(1, maxElements/2)).With(a => a.Suite = Randomizer.Number.RandomIntMinMax(101, 505).ToString())
                                                                .Random(Randomizer.Number.RandomIntMinMax(1, maxElements / 2)).With(a => a.Suite = null)
                                                            .Build())
                                    .Random(2).With(p=>p.Addresses = new List<Domain.Address>())
                                    .TheFirst(5).With(p => p.ConstructionStatus = null)
                                    .TheNext(15).With(p => p.ConstructionStatus = Randomizer.Property.GenerateRandomPropertyBuildingStatus())
                                    .Build();

            var json = JsonConvert.SerializeObject(mockData);

            reader.generateObjectRandomData<Domain.Property>(property);


            Type t = typeof(Domain.Property);
            MethodInfo[] methods = t.GetMethods();
            MemberInfo[] members = t.GetMembers();
            FieldInfo[] fields = t.GetFields();
            PropertyInfo[] properties = t.GetProperties();


            //var properties = Builder<Domain.Property>
            //                        .CreateListOfSize(500)
            //                        .All()
            //                        .With(p => p.ConstructionStatus = Randomizer.Property.GenerateRandomPropertyBuildingStatus())
            //                        .And(p => p.CountryCode = Randomizer.Address.GenerateRandomCountryCode())
            //                        .Build();


            var contacts = Builder<Contact>
                            .CreateListOfSize(700)
                            .All()
                            .With(c => c.FirstName = Randomizer.Person.GenerateRandomFirstName())
                            .And(c => c.LastName = Randomizer.Person.GenerateRandomLastName())
                            .And(c => c.BirthDate = Randomizer.Date.GenerateRandomBirthdateMinAge(18))
                            .And(c => c.EmailAddress = Randomizer.Person.GenerateRandomEmailForName(c.FirstName))
                            .And(c => c.PhoneNumber = Randomizer.Person.GenerateRandomPhone())
                            .Build();
        }
    }
}
