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


public virtual void PrintEnemyInfos(){Console.WriteLine($"The new enemy is called {EnemyName}.");}

// public void RandomAttack(){
//    Console.WriteLine( "RandomAttack");
// Random rand = new Random();
// List<string>DifferentAttack =AttackList;


// int i= rand.Next( AttackList.Count);
// Console.WriteLine($"the attack used is:{AttackList[i]}");

// }


    
public void PrintEnemyAttackList(){
foreach(String attack in AttackList)
 {
    Console.WriteLine(attack);
    }

 
}



// // // Inside of the Enemy class// Inside of the Enemy class
// public void PerformAttack(Enemy Target, Attack ChosenAttack)
// {
//     // Write some logic here to reduce the Targets health by your Attack's DamageAmount
//     Console.WriteLine($"{Name} attacks {Target.Name}, dealing {Attack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
// }












}


