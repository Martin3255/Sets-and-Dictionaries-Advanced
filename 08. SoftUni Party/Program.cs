var guests = new HashSet<string>();

while (true)
{
    string input = Console.ReadLine();
    if (input == "PARTY")
    {
        break;
    }
    guests.Add(input);
}
while (true)
{
    string command = Console.ReadLine();
    if (command == "END")
    {
        break;
    }
    if (guests.Contains(command))
    {
        guests.Remove(command);
    }
}
Console.WriteLine(guests.Count);
foreach (var guest in guests)
{
    char[] chars= guest.ToCharArray();
    if (char.IsDigit(chars[0]))
    {
        Console.WriteLine(guest);
    }
}
foreach (var guest in guests)
{
    char[] chars = guest.ToCharArray();
    if (char.IsLetter(chars[0]))
    {
        Console.WriteLine(guest);
    }
}
