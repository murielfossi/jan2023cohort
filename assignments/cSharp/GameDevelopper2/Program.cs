//Create instances of the Melee, Ranged, and Magic Caster classes
MeleeFighter Melee_Player1 = new MeleeFighter("Melee_Player1");
RangedFighter Ranged_Player1 = new RangedFighter("Ranged_Player1");
MagicHeal MagicHeal_Player1 = new MagicHeal("MagicHeal_player1");
//activate a method
Melee_Player1.PrintEnemyInfos();
Melee_Player1.PrintEnemyAttackList();




//Perform the Kick Attack from your Melee class character on your Ranged character

MagicHeal_Player1.PerformAttack(Ranged_Player1, Melee_Player1.AttackList[2]);

//Perform the Rage method from your Melee class character on your Magic Caster character

// MagicHeal_Player1.PerformAttack(MagicHeal_Player1, Melee_Player1.Rage());

//Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
Ranged_Player1.PerformAttack(Melee_Player1, Ranged_Player1.AttackList[0]);
// Have your Ranged character perform the Dash method
Ranged_Player1.Dash();
Ranged_Player1.PerformAttack(Melee_Player1, Ranged_Player1.AttackList[0]);

//have magic caster perform heal on range fighter and try attack again

MagicHeal_Player1.PerformAttack(Melee_Player1, MagicHeal_Player1.AttackList[0]);
MagicHeal_Player1.Heal(Ranged_Player1);
MagicHeal_Player1.Heal(MagicHeal_Player1);

