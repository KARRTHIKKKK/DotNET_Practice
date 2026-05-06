
List<int> marks = new List<int>();

Console.WriteLine("Enter marks for 5 students:");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Student {i + 1}: ");
    marks.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.WriteLine("\n----- Result -----");
Console.WriteLine($"Average Marks : {GetAverage(marks)}");
Console.WriteLine($"Highest Marks : {GetHighest(marks)}");
Console.WriteLine($"Lowest Marks  : {GetLowest(marks)}");

static double GetAverage(List<int> marks)
{
    return marks.Average();
}

static int GetHighest(List<int> marks)
{
    return marks.Max();
}

static int GetLowest(List<int> marks)
{
    return marks.Min();
}