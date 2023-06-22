namespace BunkerContracts;

public record BunkerResponse
(
    Guid Id,
    string Name,
    string Description,
    string Country,
    string Region,
    string Province,
    string City,
    double Latitude,
    double Longitude,
    string Image,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime 
);