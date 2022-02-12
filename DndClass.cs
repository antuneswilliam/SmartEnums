using Ardalis.SmartEnum;

public abstract class DndClass : SmartEnum<DndClass>
{
    protected DndClass(string name, int value) : base(name, value)
    {
    }

    public static readonly DndClass Barbarian = new BarbarianClass();
    public static readonly DndClass Bard = new BardClass();
    public static readonly DndClass Cleric = new ClericClass();
    public static readonly DndClass Druid = new DruidClass();
    public static readonly DndClass Fighter = new FighterClass();
    public static readonly DndClass Monk = new MonkClass();
    public static readonly DndClass Paladin = new PaladinClass();
    public static readonly DndClass Ranger = new RangerClass();
    public static readonly DndClass Rogue = new RogueClass();
    public static readonly DndClass Sorcerer = new SorcererClass();
    public static readonly DndClass Warlock = new WarlockClass();
    public static readonly DndClass Wizard = new WizardClass();

    public abstract string Action { get; }

    private sealed class BarbarianClass : DndClass
    {
        public BarbarianClass() : base("Barbarian", 1)
        {
        }
        public override string Action => "enters Rage and attacks with his Greataxe";
    }

    private sealed class BardClass : DndClass
    {
        public BardClass() : base("Bard", 2)
        {
        }
        public override string Action => "casts Thunderwave";
    }

    private sealed class ClericClass : DndClass
    {
        public ClericClass() : base("Cleric", 3)
        {
        }
        public override string Action => "heals the party";
    }

    private sealed class DruidClass : DndClass
    {
        public DruidClass() : base("Druid", 4)
        {
        }
        public override string Action => "turns into a Bear!!!";
    }

    private sealed class FighterClass : DndClass
    {
        public FighterClass() : base("Fighter", 5)
        {
        }
        public override string Action => "attacks twice with his Greatsword";
    }

    private sealed class MonkClass : DndClass
    {
        public MonkClass() : base("Monk", 6)
        {
        }
        public override string Action => "uses Flurry of Blows";
    }

    private sealed class PaladinClass : DndClass
    {
        public PaladinClass() : base("Paladin", 7)
        {
        }
        public override string Action => "uses Smite!";
    }

    private sealed class RangerClass : DndClass
    {
        public RangerClass() : base("Ranger", 8)
        {
        }
        public override string Action => "shoots an Arrow while his Panther bites another enemy";
    }

    private sealed class RogueClass : DndClass
    {
        public RogueClass() : base("Rogue", 9)
        {
        }
        public override string Action => "uses Sneak Attack";
    }

    private sealed class SorcererClass : DndClass
    {
        public SorcererClass() : base("Sorcerer", 10)
        {
        }
        public override string Action => "casts Magic Missile";
    }

    private sealed class WarlockClass : DndClass
    {
        public WarlockClass() : base("Warlock", 11)
        {
        }
        public override string Action => "casts Eldritch Blast";
    }

    private sealed class WizardClass : DndClass
    {
        public WizardClass() : base("Wizard", 12)
        {
        }
        public override string Action => "casts Fireball";
    }

}