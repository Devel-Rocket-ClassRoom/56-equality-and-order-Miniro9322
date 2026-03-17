using System;

class Item : IEquatable<Item>
{
    public string Name { get; private set; }
    public int Id { get; private set; }

    public Item(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public bool Equals(Item other)
    {
        return Name == other.Name && Id == other.Id;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Item);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Id);
    }

}