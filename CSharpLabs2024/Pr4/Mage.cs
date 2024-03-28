namespace Pr4;

public class Mage : Player
{
    private int _magicLevel;
    private List<ISpell> _spells;

    public int MagicLevel
    {
        get => _magicLevel;
        set => _magicLevel = value;
    }

    public List<ISpell> Spells
    {
        get => _spells;
        set => _spells = value;
    }


    public Mage(string name,string surname,int hp, List<ISpell> spellList, int magicLevel)
    {
        Name = name;
        Surname = surname;
        Hp = hp;
        _spells = spellList;
        _magicLevel = magicLevel;
    }

    public override void CastSpell(int spellID, Player target)
    {
        Console.Write(Name + " ");
        _spells[spellID].Cast(target, _magicLevel);
        Console.WriteLine($"{target.Name} hp: {target.Hp}");
    }

    public void PrintSpellsList()
    {
        int i = 0;
        foreach (ISpell spell in _spells)
        {
            if (spell is AttackingSpell)
            {
                Console.WriteLine($"{i} - {spell.Name} (attack)");
            }
            else
            {
                Console.WriteLine($"{i} - {spell.Name} (heal)");
            }
            ++i;
        }
    }
    
}