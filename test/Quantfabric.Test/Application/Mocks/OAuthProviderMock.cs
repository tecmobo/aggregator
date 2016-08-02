﻿using System;
using Aggregator.Test.Helpers.Mocks;
using LightMock;
using Material.Contracts;
using Material.Enums;
using Material.Infrastructure.Credentials;

namespace Aggregator.Test.Mocks
{
    using System.Threading.Tasks;

    public class OAuthProviderMock<TCredentials> : 
        MockBase<IOAuthFacade<TCredentials>>, 
        IOAuthFacade<TCredentials>
        where TCredentials : TokenCredentials
    {
        public ResponseTypeEnum ResponseType { get; private set; }
        public Uri CallbackUri => new Uri("http://www.google.com");

        public Task<Uri> GetAuthorizationUriAsync(string userId)
        {
            var result = _invoker.Invoke(a => a.GetAuthorizationUriAsync(userId));
            if (result != null)
            {
                return result;
            }
            else
            {
                var uri = new Uri("http://www.google.com");
                return Task.FromResult(uri);
            }
        }

        public Task<TCredentials> GetAccessTokenAsync(TCredentials result, string secret)
        {
            var thisResult = _invoker.Invoke(a => a.GetAccessTokenAsync(result, secret));
            return thisResult;
        }

        public OAuthProviderMock<TCredentials> SetResponseType(
            ResponseTypeEnum responseType)
        {
            ResponseType = responseType;

            return this;
        }

        public OAuthProviderMock<TCredentials> SetAccessTokenResult(TCredentials result)
        {
            _context.Arrange(
                a => a.GetAccessTokenAsync(
                    The<TCredentials>.IsAnyValue, 
                    The<string>.IsAnyValue))
                    .Returns(Task.FromResult(result));

            return this;
        }
    }
}
