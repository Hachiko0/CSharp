namespace KrasnoSeloShop.Data.Migrations
{
    using KrasnoSeloShop.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KrasnoSeloShopContext>
    {
        private static Random random = new Random();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "KrasnoSeloShop.Data.KrasnoSeloShopContext";
        }

        protected override void Seed(KrasnoSeloShopContext context)
        {
            string jeansUrl = "/Images/Jeans/jeans";
            string swimSuitUrl = "/Images/Swimsuits/swimsuit";
            string TshirtsUrl = "/Images/TShirts/tshirt";
            context.Jeans.AddOrUpdate(AddJeans(jeansUrl));
            context.Swimsuit.AddOrUpdate(AddSwimSuits(swimSuitUrl));
            context.TShirts.AddOrUpdate(AddTShirts(TshirtsUrl));
        }
        private static Jeans[] AddJeans(string url)
        {
            Jeans[] jeans = new Jeans[6];
            for (int i = 0; i < jeans.Length; i++)
            {
                jeans[i] = new Jeans()
                {
                    Name = "jeans" + (i + 1),
                    URL = url + (i + 1) + ".jpg",
                    Price = random.Next(40, 55),
                    Size = random.Next(30, 38),
                    IsAvailable = true
                };
            }
            return jeans;
        }
        private static Swimsuit[] AddSwimSuits(string url)
        {
            Swimsuit[] swimsuits = new Swimsuit[20];
            for (int i = 0; i < swimsuits.Length; i++ )
            {
                swimsuits[i] = new Swimsuit()
                {
                    Name = "swimsuits" + (i + 1),
                    URL = url + (i + 1) + ".jpg",
                    Price = random.Next(40, 55),
                    Size = random.Next(30, 38),
                    IsAvailable = true
                };
            }
            return swimsuits;
        }
        private static TShirt[] AddTShirts(string url)
        {
            TShirt[] tshirts = new TShirt[3];
            for(int i = 0; i < 3; i++)
            {
                tshirts[i] = new TShirt()
                {
                    Name = "tshirt" + (i + 1),
                    URL = url + (i + 1) + ".jpg",
                    Price = random.Next(15, 26),
                    Size = random.Next(30, 38),
                    IsAvailable = true
                };
            }
            return tshirts;
        }
    }
}
