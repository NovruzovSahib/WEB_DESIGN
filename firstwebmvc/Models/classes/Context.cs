using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
     

namespace firstwebmvc.Models.classes
{
    public class Context:DbContext
    {
        public DbSet<Bacarıqlar> bacarıqlars { get; set; }
    }
}