namespace SoftwareCodeFirst.Migrations
{
    using SoftwareCodeFirst.Models;
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

            //utilizamos la variable del tipo BlogContex para decirle
            //segun el Id vamos  a agregar un nuevo comentario
            context.Comentarios.AddOrUpdate(x => x.Id,
                new SoftwareCodeFirst.Models.Comentarios()
                {
                    Id=1,
                    Autor="Ezequiel",   
                    BlogPostId=1,
                    Contenido="Este es un contenido de ejemplo"
                }
                );
        }
    }
}
