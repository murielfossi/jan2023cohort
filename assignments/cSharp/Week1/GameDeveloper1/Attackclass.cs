class Attack 
{public string AttackName;
 public int AttackDamageAmount;

//My consructor  theAttack and theAttackDamageAmount  are just 2 parameter
 public Attack(string theAttackName, int theAttackDamageAmount){
 AttackName = theAttackName;
 AttackDamageAmount = theAttackDamageAmount;}

//Methods=function that will print information in the attack class
public void PrintAttackInfo(){
Console.WriteLine($"The Attack name is : {AttackName} and this attack makes this amount  of damages :{AttackDamageAmount}.");
}

}

