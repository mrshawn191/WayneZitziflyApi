using System.ComponentModel.DataAnnotations;

namespace WayneZitziflyApi.Model
{
    // Emmylundsvägen 5, lgh 1411 - 17171 solna, stockholm
    public class Address
    {
        [Required]
        public string Street { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }
    }
}