using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billet_pris
{

    public class Destination : IEquatable<Destination>
    {
        public string Name { get; set; }
        public int Zone { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Destination objAsPart = obj as Destination;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override int GetHashCode() 
        {
            return Zone;
        }

        public bool Equals(Destination other)
        {
            if (other == null) return false;
            return (this.Zone.Equals(other.Zone));
        }
    }
}
