using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }   // Primary Key
        public string Name { get; set; }   // Hotel Name
        public string Address { get; set; }   // Hotel Address
        public double Rating { get; set; }   // Hotel Rating
        
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }   // Foreign Key
        public Country Country { get; set; }   // Navigation Property
    }
}
