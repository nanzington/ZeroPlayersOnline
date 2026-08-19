using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.DataTypes {
    public class TwoWayString : IEquatable<TwoWayString> {
        public string first;
        public string second;

        public TwoWayString(string f, string s) {
            first = f;
            second = s;
        }

        public bool Equals(TwoWayString other) {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return (first.Equals(other.first) && second.Equals(other.second)) || (first.Equals(other.second) && second.Equals(other.first));
        }

        public override bool Equals(object obj) { 
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true; 
            if (obj.GetType() != this.GetType()) return false;
             
            return Equals((TwoWayString) obj);
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
