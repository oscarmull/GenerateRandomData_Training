using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastracture.Randomizers
{
    public class Number
    {
        public int RandomIntMinMax(int min, int max)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(min, max);

        }

        public int RandomIntMinMaxOut(int min, int max, out int val){
            val = this.RandomIntMinMax(min, max);
            return val;
        }

        public int GenerateLowerPartOfRange(int min, int max)
        {
            return this.RandomIntMinMax(min, max - 1);
        }
        //public T[] getArray<T>(int count)
        //{
        //    T[] v = new T[count];
        //    return Faker.ArrayFaker.SelectFrom<T>(1);
        //}
    }
}
