using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace CakeMaster.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "CakeMaster";
        private const string adminPassword = "GoColts09@@";
        public static async Task EnsurePopulated(UserManager<IdentityUser>
         userManager)
        {
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Carlos");
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}