using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Attributter;
using Infrastracture.Randomizers;

namespace Infrastracture
{
    public class ObjectRandomizer
    {

        public void generateObjectRandomData<T>(T item)
        {
            Type typeOfT = item.GetType();
            PropertyInfo[] properties = typeOfT.GetProperties();
            foreach (var objectProperty in properties)
            {
                var customAttributes = objectProperty.GetCustomAttributes(false);
                foreach (var customAttribute in customAttributes)
                {
                    Type attributeType = customAttribute.GetType();
                    if (attributeType.Equals(typeof(Attributter.SingleFieldMetadata)))
                    {
                        SingleFieldMetadata metadata = (SingleFieldMetadata)customAttribute;
                        Type randomType = (Type)metadata.TypeOfRandomizer;
                        var objectInstance = Activator.CreateInstance(randomType);
                        MethodInfo methodToExecute = randomType.GetMethod(metadata.SpecificRandomizer);
                        objectProperty.SetValue(item, methodToExecute.Invoke(objectInstance, metadata.RandomizerParameters));
                    }
                    else {
                        ListMetadata metadata = (ListMetadata)customAttribute;
                        Type elementType = (Type)metadata.TypeOfElement;
                        Type listType = typeof(List<>);
                        Type finalListType = listType.MakeGenericType(elementType);
                        object theList = Activator.CreateInstance(finalListType);
                        MethodInfo addToMyList = theList.GetType().GetMethod("Add");
                        int numberOfRecords = Randomizer.Number.RandomIntMinMax(metadata.MinNumberOfElements, metadata.MaxNumberOfElements);
                        if (numberOfRecords > 0) {
                            for (int i = 0; i < metadata.MaxNumberOfElements; i++)
                            {
                                var objectInstance = Activator.CreateInstance(elementType);
                                this.generateObjectRandomData<Object>(objectInstance);
                                addToMyList.Invoke(theList, new object[] { objectInstance });
                            }
                        }
                        objectProperty.SetValue(item, theList);
                    }
                }
            }
        }

        

    }
}
