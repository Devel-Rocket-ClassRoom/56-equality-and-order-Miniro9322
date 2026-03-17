class Product
{
    public string Name;
    public int Price;

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name}: {Price}원";
    }
}