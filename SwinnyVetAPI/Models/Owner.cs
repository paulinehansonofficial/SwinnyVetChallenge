using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwinnyVetAPI.Models
{
    public class Owner
    {
        int OwnerID { get; set; }
        string GivenName { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}