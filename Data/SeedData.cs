using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class SeedData
    {
        public void Seed()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ECommerceContext>();

            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            using (ECommerceContext context = new ECommerceContext(optionsBuilder.Options))
            {
                Manufacturer Apple = new Manufacturer("Apple", "USA", "Luxury company for luxury people");
                Manufacturer Samsung = new Manufacturer("Samsung", "South Corea", "Good company for middle class");
                Manufacturer Xiaomi = new Manufacturer("Xiaomi", "China", "Top for its money");

                Seria IPhone14Pro = new Seria("IPhone 14 pro", Apple);
                Seria IPhone12 = new Seria("IPhone 12", Apple);
                Seria IPhone14 = new Seria("IPhone 14", Apple);

                Seria SamsungA52 = new Seria("Samsung A52", Samsung);
                Seria SamsungA33 = new Seria("Samsung A33", Samsung);
                Seria SamsungA71 = new Seria("Samsung A71", Samsung);

                Seria XiaomiMi10T = new Seria("Xiaomi Mi 10T", Xiaomi);
                Seria XiaomiMi12 = new Seria("Xiaomi Mi 12", Xiaomi);
                Seria XiaomiMi11T = new Seria("Xiaomi Mi 11T", Xiaomi);

                Seria Macbook2Light = new Seria("Macbook 2 light", Apple);
                Seria Macbook3Pro = new Seria("Macbook 3", Apple);

                Phone phone1 = new Phone("IPhone 14 pro 256/8 blue super luxury", 7, 128000, 4000, "blue", 35000, "photo.jpg;luxuryphoto.png", 64, 16, Apple, IPhone14Pro, 2022, "A very luxury phone. Lorem ipsum dolore mavare");
               
                Phone phone3 = new Phone("IPhone 14 pro 128/6 red luxury", 7, 128000, 4000, "red", 33000, "dfver.jpg;wefef.png", 64, 16, Apple, IPhone14Pro, 2022, "Wow amazing phone for luxury lads");
                Phone phone4 = new Phone("IPhone 12 128/6 shit luxury", 7, 128000, 4200, "purple", 28000, "gfefg.jpg;wefef.png", 64, 16, Apple, IPhone12, 2022, "IPHONE 12 Wow amazing phone for luxury lads");
                Phone phone5 = new Phone("IPhone 14 256/8 red luxury", 7, 256000, 3800, "gold", 34000, "fedfver.jpg;wefef.png", 64, 16, Apple, IPhone14, 2022, "IPHONE 14 Wow amazing phone for luxury lads");
                Phone phone6 = new Phone("Samsung A52 64/6 blue", 6.5, 64000, 4100, "blue", 12000, "samsunga52er.jpg;wefef.png", 64, 16, Samsung, SamsungA52, 2022, "SAMSUNG A 52 Wow amazing phone for luxury lads");
                Laptop laptop = new Laptop("MAcbook light air 2", 12, 8, 512000, "white", 65000, "macbooklight.jpg;wef.png", "macOS", "intel core i5", Apple, Macbook2Light, 2018, "MACBOOK 2 LIGHT Amazing laptop for amazing people");
                Laptop laptop1 = new Laptop("MAcbook light air 2 blue", 12, 8, 512000, "blue", 65000, "macbooklightblue.jpg;wef.png", "macOS", "intel core i5", Apple, Macbook2Light, 2018, "MACBOOK 2 LIGHT BLUE Amazing laptop for amazing people");
                context.Phones.AddRange(phone1, phone3, phone4, phone5, phone6);
                context.Laptops.AddRange(laptop, laptop1);
                context.SaveChanges();

            }
        }
    }
}
