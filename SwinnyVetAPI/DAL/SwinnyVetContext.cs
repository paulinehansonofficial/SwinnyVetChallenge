using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SwinnyVetAPI.Models;

namespace SwinnyVetAPI.DAL
{
    public class SwinnyVetContext : DbContext
    {
        public SwinnyVetContext() : base("SwinnyVetContext")
        { }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Treatment> Treatments { get; set; }

    }
}