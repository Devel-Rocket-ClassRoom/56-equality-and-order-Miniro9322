using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CodingPractice
{
    internal class CustomerNameComparer : EqualityComparer<Customer>
    {
        public override bool Equals(Customer x, Customer y)
        {
            if (x == null && y == null)
            {
                return true;
            }
            if (x == null || y == null)
            {
                return false;
            }
            return x.LastName == y.LastName && x.FirstName == y.FirstName;
        }

        public override int GetHashCode(Customer obj)
        {
            if (obj == null)
            {
                return 0;
            }
            return HashCode.Combine(obj.LastName, obj.FirstName);
        }
    }
}
