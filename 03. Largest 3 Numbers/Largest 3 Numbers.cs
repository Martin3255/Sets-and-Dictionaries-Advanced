int[] input = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
List<int> sorted = new List<int>(input.OrderByDescending(x => x).Take(3));
Console.WriteLine(string.Join(" ", sorted));