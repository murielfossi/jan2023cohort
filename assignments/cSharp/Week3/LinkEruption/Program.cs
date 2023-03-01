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
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");// J'utilise printeach kan je veux print beaucoup de chose a la fois , ici jai beacoup d'eruption avec leur attribu k j doit print


// Execute Assignment Tasks here!
// Use LINQ to find the first eruption that is in Chile and print the result.


Eruption firsteruption = eruptions.FirstOrDefault(l => l.Location == "Chile");
 Console.WriteLine(firsteruption.ToString()); //Tostring est le nom de la function qui est dans la class eruption 

 //Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."

Eruption first_eruption = eruptions.FirstOrDefault(l => l.Location == "Hawaiian Is");
if(first_eruption != null) {
  Console.WriteLine(first_eruption.ToString()) ;
} else {
    Console.WriteLine("No Hawaiian Is Eruption found.");
};

//Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption first_eruption_NZ = eruptions.Where(l => l.Location == "New Zealand").FirstOrDefault(y => y.Year > 1900);
 Console.WriteLine(first_eruption_NZ.ToString());
Console.WriteLine($"================================");
 //Find all eruptions where the volcano's elevation is over 2000m and print them.

 IEnumerable<Eruption> ewve_over_2000= eruptions.Where(e=>e.ElevationInMeters >2000);
//  Console.WriteLine(ewve_over_2000.ToString()); this one did not work because its a list of things i am trying to return on my console
PrintEach(ewve_over_2000);
Console.WriteLine($"================================");

//Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
 IEnumerable<Eruption> volName_Startw_L= eruptions.Where(v=>v.Volcano.StartsWith("L"));
 PrintEach(volName_Startw_L);
Console.WriteLine($"================================");

 //Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
 int maxElevation = eruptions.Max(e => e.ElevationInMeters);
 Console.WriteLine(maxElevation);

 //Eruption maximum= eruptions.Max(e => e.ElevationInMeters);
 //Console.WriteLine(maximum); this one didn't work
Console.WriteLine($"================================");

//Use the highest elevation variable to find a print the name of the Volcano with that elevation
Eruption HeVName = eruptions.FirstOrDefault(e=>e.ElevationInMeters== maxElevation);
 Console.WriteLine(HeVName.Volcano);// une erution est compose de tous nom, annee ,location et elevation. donc je doitt aller dans l'eruption et specifier ce que je veux, dans ce casje voulais le nom uniquement. Volcano 
//// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
// var Name = eruptions.First(e => e.ElevationInMeters == maxElevation).Volcano;
// Console.WriteLine(Name);
Console.WriteLine($"================================");


//Print all Volcano names alphabetically
IEnumerable<Eruption> alpaVolcano = eruptions.OrderBy(v => v.Volcano);// je suis entrain d'imprimer par ordre alphabetic du non du volcan
PrintEach(alpaVolcano, "Volcanos in Alphabetical order:");
Console.WriteLine(value: $"================================");


//Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> ewve_before_1000= eruptions.Where(y=>y.Year <1000).OrderBy(v => v.Volcano);
PrintEach(ewve_before_1000, "eruptions that happened before the year 1000 CE alphabetically according to Volcano name.");
Console.WriteLine(value: $"================================");

// Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
 var printAllBonus = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano).Select(n => n.Volcano); //ici, j'etais oblige d'utiiliser var car je voulais selectionner une seul chose de l'eruption , jai utiliser select aussi
PrintEach(printAllBonus, "only select the volcano's name so that only the names are printed");
