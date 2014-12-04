using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplicationAngularJs.Models;

namespace WebApplicationAngularJs.context
{
    public class Allcontext:DbContext
    {
        public DbSet<Profile> Profiles { set; get; } 
    }
}