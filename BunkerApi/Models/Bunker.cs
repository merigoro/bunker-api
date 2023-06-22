namespace BunkerApi.Models;

public class Bunker{
    public Guid Id {get; set;}
    public string? Name {get; set;}
    public string? Description {get; set;}
    public string? Country {get; set;}
    public string? Region {get; set;}
    public string? Province {get; set;}
    public string? City {get; set;}
    public double Latitude {get; set;}
    public double Longitude {get; set;}
    public string? Image {get; set;}
    public DateTimeOffset CreatedDateTime {get; set;}
    public DateTimeOffset LastModifiedDateTime {get; set;}
}

