using RealEstate1.Data.Enums;
using RealEstate1.Models;

namespace RealEstate1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Estate
                if (!context.Estates.Any())
                {
                    context.Estates.AddRange(new List<Estate>()
                    {
                        new Estate()
                        {
                            Name = "Maroon's Drugs apartment",
                            Description = "This is a very interesting desrciption of the first Estate",
                            City = "Riga",
                            Address = "Balvu",
                            Price = 25000.00,
                            Size = 55.00,
                            Rooms = 3,
                            Image_url = "https://www.apartments.com/blog/sites/default/files/styles/x_large_hq/public/image/2023-06/ParkLine-apartment-in-Miami-FL.jpg?itok=kQmw64UU",
                            EstateCategory = EstateCategory.Apartment,
						},
                        new Estate()
                        {
                            Name = "Mixer's Podolsk",
                            Description = "This is a very interesting desrciption of the second Estate",
                            City = "Voronez",
                            Address = "Transport",
                            Price = 10000.00,
                            Size = 20.00,
                            Rooms = 2,
                            Image_url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348059739.jpg?k=5cbedb028430cda9a5d3c6a87505bbd02bbdbbf38855c92ad7cca9a918a8292a&o=&hp=1",
                            EstateCategory = EstateCategory.Apartment,
						},
                        new Estate()
                        {
                            Name = "Stas's Mansion of Loli's",
                            Description = "This is a very interesting desrciption of the third Estate",
                            City = "Riga",
                            Address = "Aglonas 28",
                            Price = 876000.00,
                            Size = 200.00,
                            Rooms = 8,
                            Image_url = "https://media-cdn.tripadvisor.com/media/photo-s/19/cd/46/a1/a-masion-for-sale.jpg",
                            EstateCategory = EstateCategory.Mansion,
						},
                        new Estate()
                        {
                            Name = "Estate4",
                            Description = "This is a very interesting desrciption of the fourth Estate",
                            City = "Ogre",
                            Address = "Ogre street",
                            Price = 2500000.00,
                            Size = 1000.00,
                            Rooms = 0,
                            Image_url = "https://assets.site-static.com/userFiles/1681/image/uploads/agent-1/buy-sell-land.jpg",
                            EstateCategory = EstateCategory.Land,
						},
                        new Estate()
                        {
                            Name = "Estate5",
                            Description = "This is a very interesting desrciption of the fifth Estate",
                            City = "Riga",
                            Address = "Riga street",
                            Price = 2130000.00,
                            Size = 312.00,
                            Rooms = 6,
                            Image_url = "https://thumbor.forbes.com/thumbor/fit-in/900x510/https://www.forbes.com/home-improvement/wp-content/uploads/2022/07/download-23.jpg",
                            EstateCategory = EstateCategory.House,
						}
					}) ;
                    context.SaveChanges();
                }
            }
        }
    }
}
