using System;

class BadItem : IEquatable<BadItem>
{
    public string Name { get; private set; }

    public BadItem(string name)
    {
        Name = name;
    }

    public bool Equals(BadItem other)
    {
        return Name == other.Name;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as BadItem);
    }
}