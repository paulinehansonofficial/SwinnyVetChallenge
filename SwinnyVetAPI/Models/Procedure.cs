using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SwinnyVetAPI.Models
{
    public class Procedure
    {
        public int ProcedureID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}