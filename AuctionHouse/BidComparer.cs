using System.Collections.Generic;

class BidComparer : Comparer<AuctionItem>
{
    public override int Compare(AuctionItem x, AuctionItem y)
    {
        if(x == null && y == null)
        {
            return 0;
        }
        else if(x == null)
        {
            return -1;
        }
        else if(y == null)
        {
            return 1;
        }

        int result = y.CurrentBid.CompareTo(x.CurrentBid);
        if(result != 0)
        {
            return result;
        }

        return x.Name.CompareTo(y.Name);
    }
}