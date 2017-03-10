﻿using System.Threading.Tasks;
using Material.Application;
using Material.Contracts;
using Material.Infrastructure.Credentials;
using Material.Infrastructure.Requests;
using Material.Infrastructure.Responses;

namespace Material.Infrastructure.Identities
{
    public class FacebookIdentity : IOAuthIdentity<OAuth2Credentials>
    {
        public async Task<JsonWebToken> AppendIdentity(
            JsonWebToken token, 
            OAuth2Credentials credentials)
        {
            var response = await new AuthorizedRequester(credentials)
                .MakeOAuthRequestAsync<FacebookUser, FacebookUserResponse>()
                .ConfigureAwait(false);

            token.Claims.Subject = response.Id;

            return token;
        }
    }
}
