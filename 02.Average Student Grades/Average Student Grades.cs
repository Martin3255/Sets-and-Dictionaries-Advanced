Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] student = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (!students.ContainsKey(student[0]))
        students.Add(student[0], new List<decimal>());
    students[student[0]].Add(decimal.Parse(student[1]));
}

foreach (var student in students)
{
    Console.Write($"{student.Key} -> ");
    foreach (var grade in student.Value)
    {
        Console.Write($"{grade:f2} ");
    }
    Console.WriteLine($"(avg: {student.Value.Average():f2})");
}