using System;

abstract class Character
{
    string characterType;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString() => $"Character is a {this.characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable())
        {
            return 10;
        }

        return 6;
    }
}

class Wizard : Character
{
    private bool preparedSpell = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (this.preparedSpell)
        {
            return 12;
        }

        return 3;
    }

    public void PrepareSpell()
    {
        this.preparedSpell = true;
    }

    public override bool Vulnerable()
    {
        return !this.preparedSpell;
    }
}
