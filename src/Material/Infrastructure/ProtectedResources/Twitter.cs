﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Material.Metadata;
using System;
using Material.Infrastructure.Credentials;
using Foundations.HttpClient.Enums;
using Material.Infrastructure;
using System.CodeDom.Compiler;

namespace Material.Infrastructure.ProtectedResources
{     
    /// <summary>
    /// Twitter API 1.1
    /// </summary>
    [CredentialType(typeof(OAuth1Credentials))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class Twitter  : OAuth1ResourceProvider 
    {
        public override Uri RequestUrl { get; } = new Uri("https://api.twitter.com/oauth/request_token");
        public override Uri AuthorizationUrl { get; } = new Uri("https://api.twitter.com/oauth/authenticate");
        public override Uri TokenUrl { get; } = new Uri("https://api.twitter.com/oauth/access_token");
        public override HttpParameterType ParameterType { get; } = HttpParameterType.Querystring;
        public override bool SupportsCustomUrlScheme { get; } = true;
    }
}
