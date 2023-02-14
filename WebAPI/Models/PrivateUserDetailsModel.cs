using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PrivateUserDetailsModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Genus { get; set; }
        public string HMO { get; set; }
        public int FamilyId { get; set; }
        public string Status { get; set; }
        public string SpouseId { get; set; }


    }
}
