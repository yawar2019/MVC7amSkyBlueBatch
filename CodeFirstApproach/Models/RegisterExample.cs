using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class RegisterExample
    {
        [Key]
        public int Sid { get; set; }
        [Required(ErrorMessage ="student Name is Required")]
        public string SName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="pwd and cpwd not matching")]
        public string ConfirmPwd { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Range(10,30, ErrorMessage = "Range Should be between 10 to 30")]
        public string Age { get; set; }

        [StringLength(30, ErrorMessage = "you can Enter 30 Characters Only")]
        public string Address { get; set; }
    }
}