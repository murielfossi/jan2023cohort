// Three Basic Arrays



        // Create an integer array with the values 0 through 9 inside.
        int[] number;
        number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // Console.WriteLine(number); will not work parceque avec c# on fait otrement , soit un for loop soit un each loop pour print le conteenu d'un array

        foreach (int num in number) { Console.WriteLine(num); }


        // Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".

        string[] name;
        name = new string[] { "Tim", "Martin", "Nikki", "Sara" };
        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }

        // Create a boolean array of length 10. Then fill it with alternating true/false values, 
        bool[] boolarray;
        boolarray = new bool[10] ;
     
   //  jai mis les curly braces {}a la fin de new bool[10] et ca na pas marcher parceque je suis entrain de creer un array avec une longuer
        // [10]longeur 10, ca connait dja qu'il yora {boolarray[0], boolarray[1],...boolarray[9]}      les braces son fait pour lister ce que mon array doit contenir
    
        for (int i = 1; i < 10; i++)// Avec le for loop ci , je demander d'aller dans mon array de longueur 10 , et a chaque index , balance tel valeur
        {
            if (i % 2 != 0) { boolarray[i] =true; }
            else { boolarray[i] =false; }
            Console.WriteLine(boolarray[i]);

        }
    

// List of Flavors


// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
// Output the length of the List after you added the flavors.
// Output the third flavor in the List.
// Now remove the third flavor using its index location.
// Output the length of the List again. It should now be one fewer.

//List<type> namevariable =new List<type>();


List<string> ice_cream_flavorsList = new List<string>();

ice_cream_flavorsList.Add("chocolate");
ice_cream_flavorsList.Add("vanilla");
ice_cream_flavorsList.Add("caramel");
ice_cream_flavorsList.Add("strawberry");
ice_cream_flavorsList.Add("mint");
ice_cream_flavorsList.Add("coconut");

Console.WriteLine(ice_cream_flavorsList.Count);
Console.WriteLine(ice_cream_flavorsList[3]);
ice_cream_flavorsList.RemoveAt(3);// to do the remove at the specific index , the syntax is different, removeAt(index)
Console.WriteLine(ice_cream_flavorsList.Count);

// for (int j = 0; j < ice_cream_flavorsList.Count; j++)
// {Console.WriteLine(ice_cream_flavorsList[j]);}// always make sure about your syntax//this will print all the content of my list.
 


//  User Dictionary

//create a dictionary with string key and int value and loop through it


Dictionary<string,int> grades=new Dictionary<string, int>();
grades.Add("Muriel",90 );
grades.Add("teresa",95);
grades.Add("enzo",96 );
grades.Add("pryncess",98);
grades.Add("samanta",99);

for (int k = 0; k < grades.Count; k++)
        {KeyValuePair<string, int> items=grades.ElementAt(k);
            
         Console.WriteLine($"{items.Key}:{items.Value}");
        }
        
//for each method
foreach(KeyValuePair<string,int> items in grades)//je peux mettre la virgule ou les deux point
 {
     Console.WriteLine($"{items.Key} : {items.Value}");
 }
    



// Create a dictionary that will store string keys and string values.
Dictionary<string,string> name_and_ice_cream_flavor= new Dictionary<string, string>();
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor

Random myflavorsList;
myflavorsList = new Random() ;



for (int i = 0; i < name.Length; i++)
        { name_and_ice_cream_flavor.Add(name[i], ice_cream_flavorsList[myflavorsList.Next(0, ice_cream_flavorsList.Count) ]);
        }

       foreach(KeyValuePair<string,string> items in name_and_ice_cream_flavor){
        Console.WriteLine($"{items.Key} : {items.Value}");
       }
 
     //another method to add manually
// Random rand = new Random();
// NameandFlav.Add ("Tim", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Martin", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Nikki", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Sara", iceCreamFlav[rand.Next(6)]);


// Console.WriteLine(NameandFlav["Tim"]);






﻿// SOLUTION PROJECT FOR C# ASSIGNMENT - FUNDAMENTALS II
// DO NOT COPY FOR ASSIGNMENT SUBMISSION
// TRY THE ASSIGNMENT BEFORE COMING HERE

// Three basic arrays
// Create an array with the integers 0 through 9 inside
int[] intArray = new int[] {0,1,2,3,4,5,6,7,8,9};

// Create an array with the names Tim, Martin, Nikki, and Sara
string[] namesArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};

// Create an array of length 10. Then fill it with alternating true/false values, starting with true (tip: do this using logic! Do not hard-code the values in!)
bool[] boolArray = new bool[10];
for(int i = 0; i < boolArray.Length; i++)
{
    if(i % 2 == 0)
    {
        boolArray[i] = true;
    } else {
        boolArray[i] = false;
    }
}

// List of flavors
// Create a List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> Flavors = new List<string>();
Flavors.Add("Vanilla");
Flavors.Add("Strawberry");
Flavors.Add("Chocolate");
Flavors.Add("Mint Chip");
Flavors.Add("Cookies and Cream");
Flavors.Add("Orange Cream");

// Output the length of the List after you added the flavors.
Console.WriteLine($"Length of Flavors List: {Flavors.Count}");

// Output the third flavor in the List.
Console.WriteLine($"Third flavor in the List: {Flavors[2]}");

// Now remove the third flavor using its index location.
Flavors.RemoveAt(2);

// Output the length of the List again. It should now be one fewer.
Console.WriteLine($"Length of Flavors List: {Flavors.Count}");

// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string,string> myDictionary = new Dictionary<string,string>();

// Add key/value pairs to the dictionary where each key is a name from the names array and each value is a randomly selected flavor from the flavors List
Random rand = new Random();
for(int i = 0; i < namesArray.Length; i++)
{
    myDictionary.Add(namesArray[i], Flavors[rand.Next(0,Flavors.Count)]);
}

// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach(KeyValuePair<string,string> entry in myDictionary)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}