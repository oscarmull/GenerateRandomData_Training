using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PropertyContact
    {
        public Property PropertyID { get; set; }
        public Contact ContactID { get; set; }
        public DateTime RelationshipStartDate { get; set; }
        public DateTime RelationshipEndDate { get; set; }
    }
}
