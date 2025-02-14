﻿using System;
using System.Linq;
using Material.Framework.Enums;
using Material.Framework.Extensions;
using Material.HttpClient.Cryptography.Algorithms;
using Material.Workflow.AuthenticatorParameters;
using Material.Workflow.Security;
using Xunit;

namespace Quantfabric.Test.Material.Unit
{
    [Trait("Category", "Continuous")]
    public class PkceTests
    {
        [Fact]
        public void GenerateSha256PkceBundle()
        {
            var algorithm = DigestSigningAlgorithm.Sha256Algorithm();
            var bundle = new OAuth2Sha256PkceSecurityParameterBundle(
                algorithm);

            var securityStrategy = new OAuthSecurityStrategy(
                new InMemoryCryptographicParameterRepository(), 
                TimeSpan.FromMinutes(2));
            var userId = Guid.NewGuid().ToString();

            var parameters = bundle.GetBundle(securityStrategy, userId);

            var raw = securityStrategy.GetSecureParameter(
                userId,
                OAuth2Parameter.Verifier.EnumToString());

            var expected = algorithm.SignMessage(raw, null)
                .ToBase64String()
                .Base64ToUrlEncodedBase64String();

            var actual = parameters.Single(p => p is OAuth2CodeChallenge).Value;

            Assert.Equal(expected, actual);
        }
    }
}
