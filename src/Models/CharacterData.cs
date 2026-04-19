namespace ev.Models;

public class BackpackItem
{
    public string Namn { get; set; } = "";
    public string Antal { get; set; } = "";
}

public class SpecialItem
{
    public string Namn { get; set; } = "";
    public string Bonus { get; set; } = "";
}

public class CombatRow
{
    public string DuUth { get; set; } = "";
    public string Stridsratio { get; set; } = "";
    public string FiendeUth { get; set; } = "";
}

public class DisciplinEntry
{
    public string Namn { get; set; } = "";
    public string Bonus { get; set; } = "";
    public bool Selected { get; set; } = false;
    public string Extra { get; set; } = "";
}

public class WeaponEntry
{
    public string Namn { get; set; } = "";
    public string Bonus { get; set; } = "";
    public bool Selected { get; set; } = false;
}

public class CharacterData
{
    public string Namn { get; set; } = "";
    public string Titel { get; set; } = "";

    private static readonly string[] Rangar =
        ["Novis", "Vägvisare", "Gesäll", "Följeslagare", "Invigd",
         "Aspirant", "Väktare", "Vandrare", "Expert", "Mästare"];

    public string Rang => Rangar[Math.Clamp(KaiDiscipliner.Count(d => d.Selected), 1, Rangar.Length) - 1];

    public List<DisciplinEntry> KaiDiscipliner { get; set; } = new()
    {
        new() { Namn = "Djurvän" },
        new() { Namn = "Hela",              Bonus = "+1" },
        new() { Namn = "Jakt" },
        new() { Namn = "Kamouflage" },
        new() { Namn = "Mental Attack",     Bonus = "+2" },
        new() { Namn = "Mental Sköld" },
        new() { Namn = "Spåra" },
        new() { Namn = "Telekinesi" },
        new() { Namn = "Varsebli" },
        new() { Namn = "Vapenskicklighet",  Bonus = "+2" },
        new() { Namn = "Vapenskicklighet" }
    };

    public string Utseende { get; set; } = "";

    public string Gulddaler { get; set; } = "";
    public bool[] Maltider { get; set; } = new bool[10];

    public List<BackpackItem> Ryggsack { get; set; } =
        Enumerable.Range(0, 8).Select(_ => new BackpackItem()).ToList();

    public List<SpecialItem> Specialforemal { get; set; } =
        Enumerable.Range(0, 8).Select(_ => new SpecialItem()).ToList();

    // Combat page
    public string Stridsvarde { get; set; } = "";
    public string Uthallighet { get; set; } = "";

    public List<CombatRow> Stridstabell { get; set; } =
        Enumerable.Range(0, 10).Select(_ => new CombatRow()).ToList();

    public List<WeaponEntry> Vapen { get; set; } = new()
    {
        new() { Namn = "Dolk" },
        new() { Namn = "Spjut" },
        new() { Namn = "Stridsklubba" },
        new() { Namn = "Kortsvärd" },
        new() { Namn = "Stridshammare" },
        new() { Namn = "Svärd" },
        new() { Namn = "Stridsyxa" },
        new() { Namn = "Stav" },
        new() { Namn = "Bredsvärd" },
        new(),
        new(),
        new()
    };

    public string Anteckningar { get; set; } = "";
}
