using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastracture.Randomizers
{
    public class Randomizer 
    {
        public static Person Person { get { return new Person(); } }
        public static Number Number { get { return new Number(); } }
        public static Enterprise Enterprise { get { return new Enterprise(); } }
        public static Internet Internet { get { return new Internet(); } }
        public static Address Address { get { return new Address(); } }
        public static Text Text { get { return new Text(); } }
        public static Property Property { get { return new Property(); } }
        public static DateGen Date { get { return new DateGen(); } }
        public static Boolean Boolean { get { return new Boolean(); } }

       
    }
}
