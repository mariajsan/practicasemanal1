using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class eventoscontextdb:DbContext
    {
        public eventoscontextdb() : base("MyConnection")
        {

        }
        public DbSet<eventos> Eventos { get; set; }
    }
}