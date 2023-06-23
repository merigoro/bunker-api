using BunkerApi.Models;
using BunkerContracts;

namespace BunkerApi.Mappers
{
    public static class BunkerMapper
    {
        public static Bunker AsModel(this BunkerCreate bunkerCreate)
        {
            return new Bunker
            {
                Name = bunkerCreate.Name,
                Description = bunkerCreate.Description,
                Country = bunkerCreate.Country,
                Region = bunkerCreate.Region,
                City = bunkerCreate.City,
                Province = bunkerCreate.Province,
                Latitude = bunkerCreate.Latitude,
                Longitude = bunkerCreate.Longitude,
                Image = bunkerCreate.Image
            };
        }
        public static Bunker AsModel(this BunkerUpdate bunkerUpdate)
        {
            return new Bunker
            {
                Name = bunkerUpdate.Name,
                Description = bunkerUpdate.Description,
                Country = bunkerUpdate.Country,
                Region = bunkerUpdate.Region,
                City = bunkerUpdate.City,
                Province = bunkerUpdate.Province,
                Latitude = bunkerUpdate.Latitude,
                Longitude = bunkerUpdate.Longitude,
                Image = bunkerUpdate.Image
            };
        }
        public static BunkerResponse AsResponse(this Bunker bunkerModel)
        {
            return new BunkerResponse
            (
                bunkerModel.Id,
                bunkerModel.Name,
                bunkerModel.Description,
                bunkerModel.Country,
                bunkerModel.Region,
                bunkerModel.City,
                bunkerModel.Province,
                bunkerModel.Latitude,
                bunkerModel.Longitude,
                bunkerModel.Image,
                bunkerModel.CreatedDateTime,
                bunkerModel.LastModifiedDateTime
            );
        }
    }
}
