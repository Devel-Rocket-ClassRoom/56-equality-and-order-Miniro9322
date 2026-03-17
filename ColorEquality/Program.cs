using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

Color color1 = new Color(255, 0, 0);
Color color2 = new Color(255, 0, 0);
Color color3 = new Color(0, 0, 255);

Console.WriteLine("=== 동등성 비교 ===");
Console.WriteLine($"{color1} == {color2}: {color1.Equals(color2)}");
Console.WriteLine($"{color1} == {color3}: {color1.Equals(color3)}\n");

Color color4 = new Color(250, 5, 3);
Color color5 = new Color(200, 50, 50);
Console.WriteLine("=== 유사 색상 판정 ===");
Console.WriteLine($"{color1}과 {color4}은 유사한가 (임계값 10): {color1.IsSimilar(color4, 10)}");
Console.WriteLine($"{color1}과 {color5}은 유사한가 (임계값 10): {color1.IsSimilar(color5, 10)}\n");

Console.WriteLine("=== HashSet 중복 제거 ===");
HashSet<Color> colors = new HashSet<Color>();
colors.Add(new Color(255, 0, 0));
colors.Add(new Color(0, 255, 0));
colors.Add(new Color(0, 0, 255));
colors.Add(new Color(255, 0, 0));
Console.WriteLine("팔레트에 추가된 색상:");
int count = 0;
foreach(var  color in colors)
{
    Console.WriteLine(color);
    count++;
}
Console.WriteLine($"색상 수: {count}\n");

Console.WriteLine($"{color1} 포함 여부: {colors.Contains(color1)}");

