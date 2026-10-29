namespace BlazorDbzPersonagem.Models;

public sealed class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Image { get; set; }
    public Planet? OriginPlanet { get; set; }
    public List<Transformation>? Transformations { get; set; }
}

public sealed class Planet
{
    public string Name { get; set; } = string.Empty;
    public bool IsDestroyed { get; set; }
}

public sealed class Transformation
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Image { get; set; }
    public string? Ki { get; set; }
}
