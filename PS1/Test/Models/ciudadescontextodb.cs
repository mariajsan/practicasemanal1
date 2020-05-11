using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Test.Models
{
    public class ciudadescontextodb : DbContext
    {
        public ciudadescontextodb() : base("MyConnection")
        {

        }
        public DbSet<ciudades> Ciudades { get; set; }
    }
}