namespace BunkerContracts
{
    public record BunkerCreate
    (
        string Name,
        string Description,
        string Country,
        string Region,
        string Province,
        string City,
        double Latitude,
        double Longitude,
        string Image
    );
}
