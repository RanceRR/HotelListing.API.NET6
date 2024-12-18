namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }   // Primary Key
        public string Name { get; set; }   // Country Name
        public string ShortName { get; set; }   // Country Short Name

        public virtual IList<Hotel> Hotels { get; set; }   // Navigation Property
    }
}