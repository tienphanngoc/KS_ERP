using KSERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Oganization
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public Gender Gender { get; set; }
        public DateTime? DoB { get; set; }
        public DateTime JoinDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IdentityCardNo { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime PlaceOfIssue { get; set; }
        public string ProfileImage { get; set; }

        //Navigation
        public virtual HashSet<PositionEmployee> PositionEmployees { get; set; }
    }
}
