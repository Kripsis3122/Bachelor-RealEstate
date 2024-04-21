using RealEstate1.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace RealEstate1.Models
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name of the Estate")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Display(Name = "City")]
        public string? City { get; set; }
        [Display(Name = "Address")]
        public string? Address { get; set; }
        [Display(Name = "Price, €")]
        public double Price  { get; set; }
        [Display(Name = "Size, м²")]
        public double Size  { get; set; }
        [Display(Name = "Number of rooms")]
        public double Rooms  { get; set; }
        [Display(Name = "Estate picture URL")]
        public string? Image_url { get; set; }
        public EstateCategory EstateCategory { get; set; }
        
    }
}
