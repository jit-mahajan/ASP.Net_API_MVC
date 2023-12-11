using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiEx2.Models
{
    public class DatabaseContact :DbContext
    {
        public DatabaseContact() :base("DefaultConnection")
        {
            
        }
        public DbSet<User> Users { get; set; }

    }
}