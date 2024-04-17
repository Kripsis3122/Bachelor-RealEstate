using RealEstate1.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace RealEstate1.Models
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public double Price  { get; set; }
        public double Size  { get; set; }
        public double Rooms  { get; set; }
        public string? Image_url { get; set; }
        public EstateCategory EstateCategory { get; set; }

    }
}
