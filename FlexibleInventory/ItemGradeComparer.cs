using System;
using System.Collections.Generic;

class ItemGradeComparer : EqualityComparer<Item>
{
    public override bool Equals(Item x, Item y)
    {
        if (x.Grade == null && y.Grade == null)
        {
            return true;
        }
        if (x.Grade == null || y.Grade == null)
        {
            return false;
        }
        return x.Grade == y.Grade;
    }

    public override int GetHashCode(Item obj)
    {
        return HashCode.Combine(obj.Grade);
    }
}