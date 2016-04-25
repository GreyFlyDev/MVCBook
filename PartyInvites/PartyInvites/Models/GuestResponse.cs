using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Used for Validation
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        //Starting Process For Basic Model
        //Validations Occur at an reference of the Model
        //Validate- This field is required if not show ERROR MSG
        [Required(ErrorMessage = "Please Enter Your Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage="Please Enter Valid Email")]
        public String Email { get; set; }

        [Required(ErrorMessage="Please Enter Phone")]
        public String Phone { get; set; }

        [Required(ErrorMessage="Please Specify Your Attendance")]
        public bool? WillAttend { get; set; }
    }
}