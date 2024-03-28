namespace Pr4;

public class AttackingSpell : ISpell
{
    private int Damage { get; }
    public string Name { get;  }

    public AttackingSpell(int damage, string name)
    {
        Damage = damage;
        Name = name;
    }

    public void Cast(Player target, int magicBonus)
    {
        Console.WriteLine($"using {Name} on {target.Name}");
        target.TakeDamage(Damage * (int)(magicBonus * 0.5));
    }
}