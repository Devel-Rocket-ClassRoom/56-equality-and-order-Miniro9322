using System;

class TodoTask : IComparable<TodoTask>
{
    public string Title { get; private set; }
    public int Priority { get; private set; }
    public string DueDate { get; private set; }
    public bool IsCompleted { get; private set; }

    public TodoTask(string title, int priority, string dueDate)
    {
        Title = title;
        Priority = priority;
        DueDate = dueDate;
    }

    public int CompareTo(TodoTask other)
    {
        int result = other.Priority.CompareTo(Priority);
        if(result != 0)
        {
            return result;
        }
        result = DueDate.CompareTo(other.DueDate);
        if (result != 0)
        {
            return result;
        }
        return Title.CompareTo(other.Title);
    }

    public override string ToString()
    {
        return $"  [우선순위 {Priority}] {Title} (마감: {DueDate})";
    }
}