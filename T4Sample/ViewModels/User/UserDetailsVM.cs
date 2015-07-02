using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T4Sample.ViewModels.User
{
    public class UserDetailsVM
    {
        [Display(Name = "User ID:")]
        public int UserID { get; set; }

        [Display(Name = "Name:")]
        public string Name { get; set; }
    }
}