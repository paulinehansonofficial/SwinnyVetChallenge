using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SwinnyVetAPI.Models
{
    public class Treatment
    {
        public int TreatmentID { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public double PricePaid { get; set; }
        public int PetID { get; set; }
        public int ProcedureID { get; set; }
    }
}