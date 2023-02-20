// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 

//// Create an instance of an Enemy in Program.cs
Enemy Killer = new Enemy("Killer");//create a new instance in the Enemy class
Console.WriteLine($"I am a new enemy named {Killer.EnemyName}");// i can use this, if i did not create a method.
Killer.PrintEnemyInfos();//Activate the method to have infos of the new enemy created

// // Create 3 instances of Attacks in Program.cs
Attack Knife = new Attack("Knife", 10);
Knife.PrintAttackInfo();

Attack Fireball= new Attack ("Fireball", 5);
Fireball.PrintAttackInfo();

Attack Throw = new Attack ("Throw", 25);
Throw.PrintAttackInfo();

// Console.WriteLine(Kick.AttackName);


// Add these Attacks to your Enemy instance's Attack List
Killer.AttackList.Add(Knife.AttackName);
Killer.AttackList.Add(Fireball.AttackName);
Killer.AttackList.Add(Throw.AttackName);


//print the Killer.AttackList with the method i wrote in enemy file
Killer.PrintEnemyAttackList();

 // Call on your Enemy's RandomAttack method to test that they can now perform the given Attacks
Killer.RandomAttack();

Killer.PrintEnemyInfos();