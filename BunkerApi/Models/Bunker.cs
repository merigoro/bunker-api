namespace BunkerApi.Models;

public class Bunker{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public string Country {get; set;}
    public string Region {get; set;}
    public string Province {get; set;}
    public string City {get; set;}
    public double Latitune {get; set;}
    public double Longitude {get; set;}
    public DateTime CreatedDateTime {get; set;}
    public DateTime LastModifiedDateTime {get; set;}
}

