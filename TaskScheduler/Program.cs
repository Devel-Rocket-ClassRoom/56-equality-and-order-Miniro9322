using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
List<TodoTask> tasks = new List<TodoTask>()
{
    new TodoTask("보고서 작성", 3, "2026-03-15"),
    new TodoTask("이메일 확인", 1, "2026-03-10"),
    new TodoTask("버그 수정", 3, "2026-03-10"),
    new TodoTask("회의 준비", 2, "2026-03-12"),
    new TodoTask("코드 리뷰", 3, "2026-03-10")
};

Console.WriteLine("=== 정렬 전 ===");
foreach (var task in tasks)
{
    Console.WriteLine(task);
}

tasks.Sort();
Console.WriteLine("\n=== 정렬 전 ===");
foreach (var task in tasks)
{
    Console.WriteLine(task);
}
