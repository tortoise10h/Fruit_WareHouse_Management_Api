using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace api.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}