using System;
using Microsoft.AspNetCore.Identity;

namespace Jimmy_Purnell_Development.Data
{
    public class SiteUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
