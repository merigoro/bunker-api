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
    int Latitude,
    int Longitude,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime 
);