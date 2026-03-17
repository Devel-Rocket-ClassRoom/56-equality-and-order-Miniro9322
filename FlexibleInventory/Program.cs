using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
List<Item> items = new List<Item>()
{
    new Item("불꽃 검", "무기", "전설"),
    new Item("철 갑옷", "방어구", "일반"),
    new Item("얼음 단검", "무기", "희귀"),
    new Item("미스릴 방패", "방어구", "희귀"),
    new Item("체력 물약", "소비", "일반")
};

Dictionary<Item, List<string>> typeComparer = new Dictionary<Item, List<string>>(new ItemTypeComparer());
foreach (Item item in items)
{
    if (typeComparer.ContainsKey(item)  == false)
    {
        typeComparer[item] = new List<string>();
        typeComparer[item].Add($"  - {item.Name} ({item.Grade})");
    }
    else
    {
        typeComparer[item].Add($"  - {item.Name} ({item.Grade})");
    }
}
Console.WriteLine("=== 타입별 그룹핑 ===");
foreach(var type in typeComparer)
{
    Console.WriteLine($"[{type.Key.Type}]");
    foreach(var text in type.Value)
    {
        Console.WriteLine(text);
    }
}


Dictionary<Item, List<string>> gradeComparer = new Dictionary<Item, List<string>>(new ItemGradeComparer());
foreach (Item item in items)
{
    if (gradeComparer.ContainsKey(item) == false)
    {
        gradeComparer[item] = new List<string>();
        gradeComparer[item].Add($"  - {item.Name} ({item.Type})");
    }
    else
    {
        gradeComparer[item].Add($"  - {item.Name} ({item.Type})");
    }
}
Console.WriteLine("=== 등급별 그룹핑 ===");
foreach (var type in gradeComparer)
{
    Console.WriteLine($"[{type.Key.Grade}]");
    foreach (var text in type.Value)
    {
        Console.WriteLine(text);
    }
}
