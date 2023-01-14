using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GTV.Mall.Models.ViewModel.Account
{
    public enum PasswordResult
    {
        Expired = 1,
        BeforeExpired = 2,
        ForceReset = 4,
        Success = 0,
        Update = 3,
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "使用者帳號")]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool IsPersistent { get; set; }
    }

    public class LoginResult
    {
        public string Redirect { get; set; }

        public PasswordResult Password { get; set; }
    }
}
