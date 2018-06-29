using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SwinnyVetAPI.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}