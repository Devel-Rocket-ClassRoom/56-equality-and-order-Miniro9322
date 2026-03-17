class AuctionItem
{
    public string Name { get; private set; }
    public int CurrentBid { get; private set; }
    public int BidCount { get; private set; }
    public string Category { get; private set; }

    public AuctionItem(string name, int currentBid, int bidCount, string category)
    {
        Name = name;
        CurrentBid = currentBid;
        BidCount = bidCount;
        Category = category;
    }

    public override string ToString()
    {
        return $"  {Name} [{Category}] - 입찰가: {CurrentBid}골드 (입찰 {BidCount}회)";
    }
}