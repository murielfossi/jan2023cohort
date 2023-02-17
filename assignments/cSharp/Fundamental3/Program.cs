//Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out 
//the contents of a List? (There are at least 3! Check Google!)

static void PrintList(){
 List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};


for (int i=0; i < TestStringList.Count;i++){Console.WriteLine(TestStringList[i]);}
}

PrintList();


//Print Sum
//Given a List of integers, calculate and print the sum of the values.

// You should get back 33 in this example
static void SumofNumbers()

{
List<int> TestIntList = new List<int>() {2,7,12,9,3};
var sum =0 ;
for(int i=0; i<TestIntList.Count;i++)
{  sum=sum+TestIntList[i];} 
 Console.WriteLine(sum);
}
SumofNumbers();



//deuxieme methode est plus efficace car elle est Global


List<int> TestIntList = new List<int>() {2,7,12,9,3};//voici la liste dont je doit ecrire la function

static void SumOfNumbers(List<int> list)//parameter, can be any list)

  {
    var sum =0 ;
for(int i=0; i<list.Count;i++)

{  sum=sum+list[i];} 

 Console.WriteLine(sum);
   
}

SumOfNumbers(TestIntList);







//Find Max 
//Given a List of integers, find and return the largest value in the List.
// You should get back 17 in this example
static int Findmax()// ca va returner sur mon web page, jai ajouter console.writeline pour print sur mon terminal
{
    List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
    var max = TestIntList2.Max();
    Console.WriteLine(max);
    return max;
//   pour avoir le minimum
//   var min = TestIntList2.Min();

}
Findmax();


//second method  global

List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};

static int FindMax(List<int> list)
{
    var max = list.Max();
    Console.WriteLine(max);
    return max;
}
FindMax(TestIntList2);







//Square the Values
//Given a List of integers, return the List with all the values squared.
// You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};

static List<int> SquarValues(List<int> list)

{List<int> IntList3 = new List<int>();

 for (int i = 0; i < list.Count; i++)
    {int square=list[i]*list[i];
    IntList3.Add(square);
        
    }
    
    Console.WriteLine(IntList3);
 return IntList3;

}

SquarValues(TestIntList3);


//my method
// You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> TestIntlist3 = new List<int>() {1,2,3,4,5};

static List<int> SquareValues(List<int> list)

{for (int i = 0; i < list.Count; i++)
    {list[i]=list[i]*list[i];
    list.Add(list[i]);   
    }
    Console.WriteLine(list);
    return list;
    
}

SquareValues(TestIntlist3);







// 5. Replace Negative Numbers with 0

// Given an array of integers, return the array with all values below 0 replaced with 0.

int[] TestIntArray = new int[] {-1,2,3,-4,5};

static int[] NonNegatives(int[] IntArray)

{
    for (int i = 0; i < IntArray.Length; i++)

{ //for loop
    if (IntArray[i]<0 ){IntArray[i]=0;}

Console.WriteLine(IntArray[i]);

}//end of my for loop
  
  return IntArray;
}


NonNegatives(TestIntArray);





// Print Dictionary
//Given a dictionary, print the contents of the said dictionary.

Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    for (int i = 0; i < MyDictionary.Count; i++)

        {//for loop
            KeyValuePair<string, string> items=MyDictionary.ElementAt(i);
            
         Console.WriteLine($"{items.Key}:{items.Value}");
        }//end of my for loop
        
}

PrintDictionary(TestDict);



// //Given a search term, return true or false whether the given term is a key in a dictionary.
// // Use the TestDict from the earlier example or make your own

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
   
    foreach(var entry in MyDictionary) {
        if (entry.Key == SearchTerm) {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));









// //Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a 
// //number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.




// // Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// // {
// //	"Julie": 6,
// //	"Harold": 12,
// //	"James": 7,
// //	"Monica": 10
// // } 


List<int> List_number = new List<int>() {6,12,7,10};
List<string> List_name= new List<string>() {"Julie", "Harold","James","Monica"};

 static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)// Names and Numbers are parameter, one represent any string list and the other any int list lis

 {
    Dictionary<string,int> Dic = new Dictionary<string,int>();



    for (int i = 0; i < Names.Count; i++)  { Dic.Add(Names[i],Numbers[i]);} 
    
     foreach(KeyValuePair<string,int> entry in Dic)

    {Console.WriteLine($"{entry.Key} : {entry.Value}");}

    
 return Dic;
   

 } 


GenerateDictionary(List_name, List_number);











// //My own note
// static string SayHello()
// { return "Hello how are you doing today?";}

//   Console.WriteLine(SayHello() );

//   //example with return and print in the console


//   static String Ditbonjour(string firstName, string lastName)
//   {
//     return $"{firstName} {lastName}, Hello how are you doing";
    
//   }
  
//    Ditbonjour("Muriel","Fossi");
//    Console.WriteLine(Ditbonjour("Muriel","Fossi"));
   





//  static int Addnumbers(int a, int b)

//  {return a+b;}

//  Console.WriteLine(Addnumbers(20,20) );





// static int Add2numbers(){
//     var a=15;
//     var b=15;
//     return a+b;
// }
// Console.WriteLine(Add2numbers());






// // exemple du void funcion qui a print. on le call a l'exterieur. on ne veux pas que l'execution return sur le web page, mais on veux ca sur la console
// static void Sayhello()
// {
//     Console.WriteLine("Hello how are you doing today?");
// }
// // See how we called the name of the function followed by ()
// // This must be done OUTSIDE the function you created
// // ...unless you like infinite loops or are writing a recursive function
// Sayhello();






// // Notice how we specify that we will take in a string called firstName within the parentheses
// static void Saybonjour(string firstName)
// {
//     // Once inside the function, we treat firstName like any other variable
//     // The exact value of this variable will be determined only after we call it
//     // Think of the variable name as a placeholder for a value we do not know yet
//     Console.WriteLine($"Hello, {firstName}, how are you doing today?");
// }
// Saybonjour("Muriel");





// // Notice how new parameters are separated by commas and their types are defined
// static void SayBonjour(string firstName, string lastName)
// {
//     Console.WriteLine($"Hello, {firstName} {lastName}, how are you doing today?");
// }
// SayBonjour("Muriel", "Fossi");


