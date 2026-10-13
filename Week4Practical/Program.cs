string[] carManufactures = { "Ford", "Toyota", "BMW", "Honda"};


Console.WriteLine("List of car manufacturers:");

foreach (string manufacturer in carManufactures)
{
    Console.WriteLine(manufacturer);


}

Array.Sort(carManufactures);

Console.WriteLine("\nSorted list of car manufacturers:");

foreach (string manufacturer in carManufactures)
{
    Console.WriteLine(manufacturer);
}

for (int carIndex = 0; carIndex < carManufactures.Length; carIndex++)
{
    Console.WriteLine($"Car manufacturer at index {carIndex}: {carManufactures[carIndex]}");
}


// challenge 2

Console.WriteLine($"\n Challeng 2 ");


List<string> months = new List<string>();

months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");;
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

Console.WriteLine(months.Count);

months.Remove("September");
months.Remove("November");

Console.WriteLine(months.Count);

int decemberIndex= months.IndexOf("December");

Console.WriteLine(decemberIndex);

string[] monthNamesArray = months.ToArray();


Console.WriteLine($"\n Challeng 3 ");


Dictionary<string, int> inventory = new Dictionary<string, int>();

inventory.Add("Health Position", 5);
inventory.Add("Mana Potion", 2);
inventory.Add("Gold coin", 100);

inventory["Health Position"] = 20;








