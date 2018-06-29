using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SwinnyVetAPI.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }

        [StringLength(30)]
        [Required]
        public string GivenName { get; set; }

        [StringLength(30)]
        [Required]
        public string Surname { get; set; }

        [StringLength(10)]
        [RegularExpression("[0-9]+")]
        [Required]
        public string Phone { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}