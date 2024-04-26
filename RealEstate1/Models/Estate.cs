using RealEstate1.Data.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RealEstate1.Models
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name of the Estate")]
        [Required(ErrorMessage = "Name of the esate is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
		[Required(ErrorMessage = "Description is required")]
		public string Description { get; set; }
        [Display(Name = "City")]
		[Required(ErrorMessage = "City is required")]
		public string City { get; set; }
        [Display(Name = "Address")]
		[Required(ErrorMessage = "Address is required")]
		public string Address { get; set; }
        [Display(Name = "Price, €")]
		[Required(ErrorMessage = "Price is required")]
		public double Price  { get; set; }
        [Display(Name = "Size, м²")]
		[Required(ErrorMessage = "Size is required")]
		public double Size  { get; set; }
        [Display(Name = "Number of rooms")]
		public double Rooms  { get; set; }
        [Display(Name = "Estate picture URL")]
		[StringSyntax(StringSyntaxAttribute.Uri)]
		public string Image_url { get; set; }
		[Required(ErrorMessage = "Estate category is required")]
		public EstateCategory EstateCategory { get; set; }

        public DateOnly date_added { get; set; } = DateOnly.FromDateTime(DateTime.Now);

	}
}
