using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Test;
using IdentityModel;
using System.Security.Claims;

namespace MyFirstIdentityServer
{
    internal class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "patrick",
                    Password = "TopSecret4Test",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "patrick@test.com"),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }

                }
            };
        }
    }
}
