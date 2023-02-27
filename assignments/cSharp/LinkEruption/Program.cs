// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
//ceci est le method qui va print each item in a list. toujour l'avaoir audessus comme ceci
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }

}


List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions//ceci est le code pour print all le Stratocolcano de la list
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");


// Execute Assignment Tasks here!
// Use LINQ to find the first eruption that is in Chile and print the result.


Eruption firsteruption = eruptions.FirstOrDefault(t => t.Location == "Chile");
 Console.WriteLine(firsteruption.ToString()); //Tostring est le nom de la function qui est dans la class eruption 

 //Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."

Eruption first_eruption = eruptions.FirstOrDefault(t => t.Location == "Hawaiian Is");
if(first_eruption != null) {
  Console.WriteLine(first_eruption.ToString()) ;
} else {
    Console.WriteLine("No Hawaiian Is Eruption found.");
};

//Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
