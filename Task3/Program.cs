

var student1 = new Student()
{
    Name = "Alijon Sattorov",
    GradeLevel = 11,
    TestScores = new int[5] {100,88, 33, 21,12}
};

var average1 = student1.GetAverage();

if (average1 >= 90)
{
    System.Console.WriteLine($"Congratulations {student1.Name} on achieving above average scores ({average1}) in grade {student1.GradeLevel}! Keep up the good work!");
}
else if (average1 >= 70 && average1 < 85)
{
    System.Console.WriteLine($"{student1.Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {average1} in grade {student1.GradeLevel}.");
}
else if (average1>=85)
{
    System.Console.WriteLine($"Congratulations {student1.Name} on achieving an average score of {student1.GradeLevel} in grade {average1}! Keep working hard for even better results!");
}
else 
{
    System.Console.WriteLine($"Shame on you");
}


class Student
{
    public string Name;
    public int GradeLevel;
    public int[] TestScores;


    public double GetAverage()
    {
        int sum = 0;
        for (int i = 0; i < TestScores.Length; i++)
        {
            sum += TestScores[i];
        }

        return sum /(double) TestScores.Length;
    }
}
