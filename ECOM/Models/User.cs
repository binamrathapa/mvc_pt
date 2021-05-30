using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOM.Models
{
    public class User
    {
        public int Id
        {
            get;set;
        }
        [Required(ErrorMessage = "Username is required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(10,ErrorMessage ="Username can not be greater than 10 characters")]
        //[RegularExpression("[0-9A-Za-z]",ErrorMessage ="username is only number")]
        [Display(Name ="Email")]
        public string UserName
        {
            get;set;
        }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password lenght should be greater than 5")]
        [DataType(DataType.Password)]
        public string Password
        {
            get; set;
        }
        public bool IsActive
        {
            get;set;
        }
    }
}