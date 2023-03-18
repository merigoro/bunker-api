namespace Bunker.Contracts;

public record BunkerResponse
(
    Guid Id,
    string Name,
    string Description,
    string Country,
    string Region,
    string Province,
    string City,
    int Latitudine,
    int Longitude,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime 
);