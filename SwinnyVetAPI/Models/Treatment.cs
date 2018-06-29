using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwinnyVetAPI.Models
{
    public class Treatment
    {
        int TreatmentID { get; set; }
        DateTime Date { get; set; }
        string Notes { get; set; }
        double PricePaid { get; set; }

        public virtual int PetID { get; set; }
        public virtual int ProcedureID { get; set; }
    }
}