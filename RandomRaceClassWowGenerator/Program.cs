using System;
using System.Text;

namespace RandomRaceClassWowGenerator;

enum Factions
{
    Horde,
    Alience
}
enum Sex 
{
    Male,
    Female
}

enum Classes
{
    Warrior,
    Rogue,
    Paladin,
    Hunter,
    Mage,
    Warlock,
    DeathKnight,
    Druid,
    Priest,
    Shaman
}
class Race
{
    public Race(Factions _faction, Sex[] _sex, Classes[] _class)
    {
        this._faction = _faction;
        this._class = _class;
        this._sex = _sex;
    }
    Factions _faction;
    Sex[] _sex;
    Classes[] _class;
    public Factions CharacterFaction
    {
        get
        {
            return _faction;
        }
    }
    public Sex[] CharacterSex
    {
        get
        {
            return _sex;
        }
    }
    public Classes[] CharacterClass
    {
        get
        {
            return _class;
        }
    }
}
// Alience
class Human : Race
{
    public Human() : base(Factions.Alience, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Hunter, Classes.Mage, Classes.DeathKnight, Classes.Priest, Classes.Paladin, Classes.Warlock }) { }
}
class Dwarf : Race
{
    public Dwarf() : base(Factions.Alience, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Hunter, Classes.Paladin, Classes.Rogue, Classes.DeathKnight, Classes.Priest }) { }
}
class NightElf : Race
{
    public NightElf() : base(Factions.Alience, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Hunter, Classes.Rogue, Classes.DeathKnight, Classes.Priest, Classes.Druid }) { }
}
class Gnome : Race
{
    public Gnome() : base(Factions.Alience, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Rogue, Classes.DeathKnight, Classes.Mage, Classes.Warlock }) { }
}
class Draenei : Race
{
    public Draenei() : base(Factions.Alience, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Paladin, Classes.Hunter, Classes.Priest, Classes.DeathKnight, Classes.Shaman, Classes.Mage }) { }
}

// Horde

class Ork : Race
{
    public Ork() : base(Factions.Horde, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Hunter, Classes.Rogue, Classes.DeathKnight, Classes.Shaman, Classes.Warlock }) { }
}
class Undead : Race
{
    public Undead() : base(Factions.Horde, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Rogue, Classes.Priest, Classes.DeathKnight, Classes.Mage, Classes.Warlock }) { }
}
class Tauren : Race
{
    public Tauren() : base(Factions.Horde, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Hunter, Classes.DeathKnight, Classes.Shaman, Classes.Druid }) { }
}
class Troll : Race
{
    public Troll() : base(Factions.Horde, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Warrior, Classes.Hunter, Classes.DeathKnight, Classes.Shaman, Classes.Rogue, Classes.Priest, Classes.Mage }) { }
}
class BloodElf : Race
{
    public BloodElf() : base(Factions.Horde, new Sex[] { Sex.Male, Sex.Female }, new Classes[] { Classes.Hunter, Classes.DeathKnight, Classes.Paladin, Classes.Rogue, Classes.Priest, Classes.Mage, Classes.Warlock }) { }
}


class Program
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        Race[] races = new Race[] { new Human(), new Dwarf(), new NightElf(), new Gnome(), new Draenei(), new Ork(), new Undead(), new Tauren(), new Troll(), new BloodElf() };
        Race randRace = races[new Random().Next(races.Length)];
        Factions randFaction = randRace.CharacterFaction;
        Sex randSex = randRace.CharacterSex[new Random().Next(2)];
        Classes randClass = randRace.CharacterClass[new Random().Next(randRace.CharacterClass.Length)];

        switch (randFaction)
        {
            case Factions.Alience:
                sb.Append("Alience | ");
                break;
            case Factions.Horde:
                sb.Append("Horde | ");
                break;
        }
        switch (randSex)
        {
            case Sex.Male:
                sb.Append("Male | ");
                break;
            case Sex.Female:
                sb.Append("Female | ");
                break;
        }
        switch (randRace.GetType().Name)
        {
            case nameof(Human):
                sb.Append("Human |" );
                break;
            case nameof(Dwarf):
                sb.Append("Dwarf | ");
                break;
            case nameof(NightElf):
                sb.Append("Night Elf | ");
                break;
            case nameof(Gnome):
                sb.Append("Gnome | ");
                break;
            case nameof(Draenei):
                sb.Append("Draenei | ");
                break;
            case nameof(Ork):
                sb.Append("Ork | ");
                break;
            case nameof(Undead):
                sb.Append("Undead | ");
                break;
            case nameof(Tauren):
                sb.Append("Tauren | ");
                break;
            case nameof(Troll):
                sb.Append("Troll | ");
                break;
            case nameof(BloodElf):
                sb.Append("Blood Elf | ");
                break;
        }
        switch (randClass)
        {
            case Classes.Warrior:
                sb.Append("War");
                break;
            case Classes.Paladin:
                sb.Append("Paladin");
                break;
            case Classes.Hunter:
                sb.Append("Hunter");
                break;
            case Classes.Rogue:
                sb.Append("Rogue");
                break;
            case Classes.Priest:
                sb.Append("Priest");
                break;
            case Classes.DeathKnight:
                sb.Append("Death Knight");
                break;
            case Classes.Shaman:
                sb.Append("Shaman");
                break;
            case Classes.Mage:
                sb.Append("Mage");
                break;
            case Classes.Warlock:
                sb.Append("Warlock");
                break;
            case Classes.Druid:
                sb.Append("Druid");
                break;
        }
        Console.WriteLine(sb.ToString());
        
        Console.ReadLine();
    }
}
