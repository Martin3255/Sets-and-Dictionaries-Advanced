int n = int.Parse(Console.ReadLine());
HashSet<string> strings= new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    strings.Add(name);
}
foreach (var name in strings)
{
    Console.WriteLine(name);
}