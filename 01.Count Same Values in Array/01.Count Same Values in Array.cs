
Dictionary<double, int> keyValuePairs = new Dictionary<double, int>();
double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
for (int i = 0; i < input.Length; i++)
{
    if (!keyValuePairs.ContainsKey(input[i]))
    {
        keyValuePairs.Add(input[i], 0);
    }
    keyValuePairs[input[i]]++;
}
foreach (var (value, times) in keyValuePairs)
{
    Console.WriteLine($"{value} - {times} times");
}