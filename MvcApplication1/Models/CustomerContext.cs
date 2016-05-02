using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CustomerContext : DbContext
    {

        //public CustomerContext() : base("DefaultConnection")
        //{
        //}

        public DbSet<Customers> Customers { get; set; }
    }
}