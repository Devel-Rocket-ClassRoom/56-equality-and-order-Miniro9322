using System;
using System.Collections.Generic;

class ItemTypeComparer : EqualityComparer<Item>
{
    public override bool Equals(Item x, Item y)
    {
        if(x.Type == null && y.Type == null)
        {
            return true;
        }
        if(x.Type == null  || y.Type == null)
        {
            return false;
        }
        return x.Type == y.Type;
    }

    public override int GetHashCode(Item obj)
    {
        return HashCode.Combine(obj.Type);
    }
}