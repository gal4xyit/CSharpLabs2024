namespace Pr4;

class Program
{
    static void Main(string[] args)
    {
        MagicSkillsets magicList = new MagicSkillsets();
        Dictionary<MagicType, List<ISpell>> spellsByMagic = magicList.Magic;

        Player player1 = new Mage("Alexander", "Efimov", 100, spellsByMagic[MagicType.Fire], 10 );
        Player player2 = new Mage("Vitalii", "Kasianenko", 100, spellsByMagic[MagicType.Water], 10);

        magicList.PrintMagicInfo();
        
        ((Mage)player1).PrintSpellsList();
        
        player1.CastSpell(0,player2);
        player2.CastSpell(1,player2);

    }
}