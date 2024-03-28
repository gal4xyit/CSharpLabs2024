namespace Pr4;

public abstract class Player : IDamageable, IHealable
{
    private int _hp;
    private string _name;
    private string _surname;

    public int Hp
    {
        get => _hp;
        set => _hp = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value;
    }

    public void TakeHealing(int healing)
    {
        _hp += healing;
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;
    }

    public abstract void CastSpell(int spellID, Player target);

}