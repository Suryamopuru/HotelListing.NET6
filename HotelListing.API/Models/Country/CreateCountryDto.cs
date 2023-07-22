using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    //Data Transfer Objects
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }

        public string ShortName { get; set; }

    }
}
