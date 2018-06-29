using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwinnyVetAPI.Models
{
    public class Procedure
    {
        int ProcedureID { get; set; }
        string Description { get; set; }
        double Price { get; set; }
    }
}