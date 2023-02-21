public class Enemy{
    public string EnemyName;
    public int EnemyHealth;
    
   
    public List<Attack> AttackList ;
    
    

    public Enemy(string theEnemyName)// just one parameter , since we just want to get the name
    {
        EnemyName  =  theEnemyName;
        EnemyHealth  =  100;
        AttackList  = new List<Attack>();
    }


public virtual void PrintEnemyInfos(){Console.WriteLine($"The new enemy is called {EnemyName}.");}

public void RandomAttack(){
   Console.WriteLine( "RandomAttack");
Random rand = new Random();
List<Attack>DifferentAttack =AttackList;


int i= rand.Next( AttackList.Count);
Console.WriteLine($"the attack used is:{AttackList[i]}");

}

public void AddAttack(Attack newAttack)
    {
        AttackList.Add(newAttack);
        Console.WriteLine($"this {EnemyName} learned {newAttack.AttackName} a new attack .");
    }

    
public void PrintEnemyAttackList()
{
foreach(Attack attack in AttackList)
 {
    Console.WriteLine(AttackList);
    }
}

    

public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        //reduce the Targets health by your Attack's DamageAmount
      Target.EnemyHealth -= ChosenAttack.AttackDamageAmount;
        Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, used {ChosenAttack.AttackDamageAmount} damage and reducing {Target.EnemyName}'s health to {Target.EnemyHealth}!!");
    }
 
}

















