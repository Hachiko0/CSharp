namespace KrasnoSeloShop.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using KrasnoSeloShop.Models;
    using KrasnoSeloShop.Data;

    class Program
    {
        private static Random random = new Random();
        static void Main()
        {
            using (KrasnoSeloShopContext context = new KrasnoSeloShopContext())
            {
                //AddSwimSuits(context, "/Images/Swimsuits/swimsuit");
                //AddJeans(context, "/Images/Jeans/jeans");
                //AddTShirts(context, "/Images/TShirts/tshirt");
                //context.SaveChanges();
            }
        }
        private static void AddJeans(KrasnoSeloShopContext context, string url)
        {
            for (int i = 2; i < 7; i++)
            {
                //context.Jeans.Add() - позволено ми е, защото работя с конкретен тип(както в момента). Ако работя с DbContext класа ще трябва по долния начин да стане
                context.Set<Jeans>().Add(
                    new Jeans()
                    {
                        Name = "jeans" + i,
                        URL = url + i + ".jpg",
                        Price = random.Next(40, 55),
                        Size = random.Next(30, 38),
                        IsAvailable = true
                    }
                    );
            }
        }
        private static void AddSwimSuits(KrasnoSeloShopContext context, string url)
        {
            for (int i = 1; i <= 20; i++)
            {
                context.Set<Swimsuit>().Add(
                    new Swimsuit()
                    {
                        Name = "swimsuits" + i,
                        URL = url + i + ".jpg",
                        Price = random.Next(40, 55),
                        Size = random.Next(30, 38),
                        IsAvailable = true
                    }
                    );
            }
        }
        private static void AddTShirts(KrasnoSeloShopContext context, string url)
        {
            for(int i = 1; i <= 3; i++)
            {
                context.Set<TShirt>().Add(
                    new TShirt() 
                    {
                        Name = "tshirt" + i,
                        URL = url + i + ".jpg",
                        Price = random.Next(15, 26),
                        Size = random.Next(30,38),
                        IsAvailable = true
                    }
                    );
            }
        }
    }
}