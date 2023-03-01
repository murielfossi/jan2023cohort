class Enemy{
    public string EnemyName;
    public int EnemyHealth;
    public List<string> AttackList ;
    

    public Enemy(string theEnemyName)// just one parameter , since we just want to get the name
    {
        EnemyName  =  theEnemyName;
        EnemyHealth  =  100;
        AttackList  = new List<string>();
    }


public void PrintEnemyInfos(){Console.WriteLine($"The new enemy is called {EnemyName}.");}

public void RandomAttack(){
   Console.WriteLine( "RandomAttack");
Random rand = new Random();
List<string>DifferentAttack =AttackList;

// for (int i = 0; i < Attack.Count; i++) i don't need this because i don't need to loop through the attacklist. i just need 1 attack.
int i= rand.Next( AttackList.Count);//i want you to pick a number within the length of the attackList
Console.WriteLine($"the attack used is:{AttackList[i]}");

}

// public void AddAttackToAttackList(){

//    foreach (string attackk in Attack.AttackName)
//    { Console.WriteLine(AttackList.Add(attackk));}
    
//    }
  

   
    
public void PrintEnemyAttackList(){
foreach(String attack in AttackList)
 {
    Console.WriteLine(attack);
    }

 
}




}