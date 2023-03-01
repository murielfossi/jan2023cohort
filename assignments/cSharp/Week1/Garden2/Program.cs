// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//3 , elle a creer un nouveau instance in the class garden et au 4 , she activate the method for the new instance you just create.
Garden HBG = new Garden("Honey Bees Garden");//create a new instance with 
HBG.PrintGardenName();//activating a method called printedgarden using the  garden class

Plant Thyme = new Plant("Thyme", "Herb");
Thyme.PrintPlantInfo();
Plant Strawberry = new Plant("Strawberries", "Fruit");

HBG.AllPlants.Add(Thyme);
HBG.ShowPlants();
HBG.AllPlants.Add(Strawberry);
HBG.ShowPlants();

Garden JHG = new Garden("Juli's Herb Garden");
JHG.AllPlants.Add(Thyme);
JHG.ShowPlants();