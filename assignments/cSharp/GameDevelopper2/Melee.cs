public class Melee_Fighter : Enemy{

public Melee_Fighter(string theEnemyName ) :base(theEnemyName){// mon constructor pour l'enfant est tres different de celui de son parent puisque il herite d tous les attribut mais avec des valeur differente
   EnemyName  =  theEnemyName;
        EnemyHealth  =  120;
        AttackList  = new List<string>();
}

//Method, le mehod de l'enfant s'ecrit differement puisquil va herite de ces parents parent et en plus il a ces attribut propre a lui

public void PrintMelee_FighterInfos (){
Console.WriteLine($"This melee_Fighter is called ");
Console.WriteLine($"this enemy has the health of :{Melee_Fighter_Health} and he made these different attack:{AttacksName}");
}














}