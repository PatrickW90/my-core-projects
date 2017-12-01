using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4;

namespace MyFirstIdentityServer
{
    internal class Clients
    {
        public static IEnumerable<Client> GetClients()
        {
            var secret = new Secret { Value = "Password123!".Sha256() };

            return new List<Client>
            {
                new Client
                {
                ClientId = "authorizationCodeClient2",
                ClientName = "Authorization Code Client",
                ClientSecrets = new List<Secret> { secret },
                Enabled = true,
                AllowedGrantTypes = new List<string> { "authorization_code" }, //DELTA //IdentityServer3 wanted Flow = Flows.AuthorizationCode,
                RequireConsent = true,
                AllowRememberConsent = true,
                RedirectUris =
                    new List<string> {
                       "https://www.getpostman.com/oauth2/callback"
                  },
                AllowedCorsOrigins =
                    new List<string> {
                       "https://www.getpostman.com/"
                  },
                PostLogoutRedirectUris =
                    new List<string> {"https://www.getpostman.com/oauth2/callback"},
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "customAPI.read"
                },
                AccessTokenType = AccessTokenType.Jwt,
                AllowOfflineAccess = true


                },

                new Client {
                ClientId = "oauthClient",
                ClientName = "Example Client Credentials Client Application",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {
                    new Secret("Password123!".Sha256())},
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "customAPI.read"
                }
                }
            };
        }
    }
}
