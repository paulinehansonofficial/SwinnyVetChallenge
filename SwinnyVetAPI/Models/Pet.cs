using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwinnyVetAPI.Models
{
    public class Pet
    {
        int PetID { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        int OwnerID { get; set; }
    }
}