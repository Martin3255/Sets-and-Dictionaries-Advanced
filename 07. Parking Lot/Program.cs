    using System.Text.RegularExpressions;

    var input = Console.ReadLine();
    var parking = new HashSet<string>();

    while(input != "END")
    {
        var inputInfo = Regex.Split(input, ", ");
        if (inputInfo[0] == "IN")
        {
            parking.Add(inputInfo[1]);
        }
        else if (inputInfo[0] == "OUT" && parking.Contains(inputInfo[1]))
        {
            parking.Remove(inputInfo[1]);
        }
        input = Console.ReadLine();
    }
    if (parking.Count == 0)
    {
        Console.WriteLine("Parking Lot is Empty");
    }
    else
    {
        foreach (var car in parking)
        {
            Console.WriteLine(car);
        }
    }