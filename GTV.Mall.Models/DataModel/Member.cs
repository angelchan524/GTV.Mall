namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class Member
    {

        public System.Guid MemberID { get; set; }

        public string Name { get; set; }
        public string IdentityID { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string Email { get; set; }

        public string? NickName { get; set; }
        public string Zipcode { get; set; }

        public string? City { get; set; }

        public string? Area { get; set; }

        public string? Address { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> PasswordLastModify { get; set; }
        public Nullable<System.DateTime> AccountLockedTime { get; set; }
        public int LoginFailCount { get; set; }

        public System.DateTime CreatedTime { get; set; }

        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }

}
