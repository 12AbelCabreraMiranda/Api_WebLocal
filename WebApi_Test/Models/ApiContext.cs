namespace WebApi_Test.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApiContext : DbContext
    {

        public ApiContext()
            : base("name=ApiContext")
        {
        }
        //Modelo de dato
        public DbSet<Usuario> Usuarios { get; set; }

    }

    
}