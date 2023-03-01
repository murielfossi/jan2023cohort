public class MeleeFighter : Enemy{

public MeleeFighter(string theEnemyName ) :base(theEnemyName){// mon constructor pour l'enfant est tres different de celui de son parent puisque il herite d tous les attribut mais avec des valeur differente
   EnemyName  =  theEnemyName;
   EnemyHealth  =  120;
   AttackList  = new List<Attack>(){

        //Create attacklist of meleefighter
        new Attack("Punch", 20),
        new Attack("Kick", 15),
        new Attack("Tackle", 25) };



}

//Method, le mehod de l'enfant s'ecrit differement puisquil va herite de ces parents parent et en plus il a ces attribut propre a lui

public Attack MeleeFighterRandomAttack (){
{        Random rand = new Random();
        int attack = rand.Next(AttackList.Count);
        AttackList[attack].AttackDamageAmount += 10;
        Console.WriteLine($"{AttackList[attack].AttackName} now deals {AttackList[attack].AttackDamageAmount} damage");
        return AttackList[attack];}

}
}













