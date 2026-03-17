using System;

class Student : IComparable<Student>
{
    public string Name { get; private set; }
    public int Grade { get; private set; }
    public int Score { get; private set; }

    public Student(string name, int grade, int score)
    {
        Name = name;
        Grade = grade;
        Score = score;
    }

    public int CompareTo(Student other)
    {
        if(other == null)
        {
            return 1;
        }

        int result = Grade.CompareTo(other.Grade);
        if(result != 0)
        {
            return result;
        }

        result = Score.CompareTo(other.Score);
        if(result != 0)
        {
            return result; 
        }

        return Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"{Grade}학년 {Name} ({Score}점)";
    }
}