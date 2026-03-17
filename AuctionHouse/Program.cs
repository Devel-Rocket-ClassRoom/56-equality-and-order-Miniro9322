using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

List<AuctionItem> items = new List<AuctionItem>()
{
    new AuctionItem("전설의 검", 50000, 12, "무기"),
    new AuctionItem("회복 물약", 5000, 3, "소비"),
    new AuctionItem("미스릴 갑옷", 35000, 8, "방어구"),
    new AuctionItem("만능 물약", 5000, 20, "소비"),
    new AuctionItem("불꽃 반지", 28000, 15, "장신구")
};

items.Sort(new BidComparer());

Console.WriteLine("=== 입찰가 기준 정렬 (BidComparer) ===");
foreach(var item in items)
{
    Console.WriteLine(item);
}


Console.WriteLine("\n=== 입찰 횟수 기준 정렬 (Create 람다) ===");
items.Sort(Comparer<AuctionItem>.Create((x, y) => y.BidCount.CompareTo(x.BidCount)));
foreach (var item in items)
{
    Console.WriteLine(item);
}