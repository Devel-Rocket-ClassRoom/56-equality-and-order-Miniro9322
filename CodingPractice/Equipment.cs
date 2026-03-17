class Equipment
{
    public string Name;
    public string Type;

    public Equipment(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Type}: {Name}";
    }
}