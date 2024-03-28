namespace Pr4;

public class MagicSkillsets
{
    public Dictionary<MagicType, List<ISpell>> Magic { get; }

    public MagicSkillsets()
    {
        Magic = new Dictionary<MagicType, List<ISpell>>()
        {
            { MagicType.Fire , new List<ISpell>{new AttackingSpell(10,"FireBall"), new HealingSpell(12,"PhoenixFlame")}},
            { MagicType.Water , new List<ISpell>{new AttackingSpell(5,"WaterBall"), new HealingSpell(5,"HolyWater")}}
        };
    }

    public void PrintMagicInfo()
    {
        foreach (var kvp in Magic)
        {
            Console.Write($"Magic:{kvp.Key} Spells: ");
            foreach (ISpell spell in kvp.Value)
            {
                if (spell is AttackingSpell)
                {
                    Console.Write(spell.Name + "(attack)" + " ");
                }
                else
                {
                    Console.Write(spell.Name + "(heal)" + " ");
                }
            }

            Console.WriteLine("");
        }
    }
    
}