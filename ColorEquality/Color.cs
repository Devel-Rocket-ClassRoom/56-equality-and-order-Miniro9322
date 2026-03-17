using System;

class Color : IEquatable<Color>
{
    public int R { get; private set; }
    public int G { get; private set; }
    public int B { get; private set; }

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public bool IsSimilar(Color other, int threshold)
    {
        if(Math.Abs(R - other.R) <= threshold && Math.Abs(G - other.G) <= threshold && Math.Abs(B - other.B) <= threshold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Equals(Color other)
    {
        return R == other.R && G == other.G && B == other.B;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Color);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(R, G, B);
    }

    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}