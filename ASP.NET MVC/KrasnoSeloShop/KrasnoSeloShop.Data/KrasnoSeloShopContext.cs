namespace KrasnoSeloShop.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using KrasnoSeloShop.Models;
    using KrasnoSeloShop.Data.Migrations;
    public class KrasnoSeloShopContext : DbContext
    {
        public KrasnoSeloShopContext()
            : base("KrasnoSeloShopContext")
        {
            Database.SetInitializer<KrasnoSeloShopContext>(new MigrateDatabaseToLatestVersion<KrasnoSeloShopContext, Configuration>());
        }

        public DbSet<Jeans> Jeans { get; set; }
        public DbSet<TShirt> TShirts { get; set; }
        public DbSet<Swimsuit> Swimsuit { get; set; }
        public DbSet<Shorts> Shorts { get; set; }
    }
}