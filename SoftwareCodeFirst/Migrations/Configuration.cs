namespace SoftwareCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftwareCodeFirst.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(SoftwareCodeFirst.Models.BlogContext context)
        {
            //Comando que se ejecuta cada vez que uso UPDATE-DATABASE
        }
    }
}
