class MagicHeal : Enemy
{
    public MagicHeal(string theName) : base(theName)
    {
        EnemyHealth = 80;
        AttackList = new List<Attack>() {
            new Attack("Fireball", 25),
            new Attack("LightningBolt", 20),
            new Attack("StaffStrike", 10)
        };
    }
    public void Heal(Enemy healTarget) {
        healTarget.EnemyHealth += 40;
        Console.WriteLine($"This {this.EnemyName} healed {healTarget.EnemyName} for 40 health");
    }
}