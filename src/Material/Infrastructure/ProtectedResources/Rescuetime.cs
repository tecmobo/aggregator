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
using System.Collections.Generic;
using Foundations.HttpClient.Enums;
using Material.Infrastructure;
using System.CodeDom.Compiler;

namespace Material.Infrastructure.ProtectedResources
{     
    /// <summary>
    /// Rescuetime API 0
    /// </summary>
    [CredentialType(typeof(OAuth2Credentials))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class Rescuetime  : OAuth2ResourceProvider 
    {
        public override List<string> AvailableScopes { get; } = new List<string> { "time_data" };
        public override List<OAuth2FlowType> AllowedFlows { get; } = new List<OAuth2FlowType> { OAuth2FlowType.AccessCode };
        public override List<GrantType> AllowedGrantTypes { get; } = new List<GrantType> { GrantType.AuthCode };
        public override List<OAuth2ResponseType> AllowedResponseTypes { get; } = new List<OAuth2ResponseType> { OAuth2ResponseType.Code };
        public override string TokenName { get; } = "access_token";
        public override Uri AuthorizationUrl { get; } = new Uri("https://www.rescuetime.com/oauth/authorize");
        public override Uri TokenUrl { get; } = new Uri("https://www.rescuetime.com/oauth/token");
        public override bool SupportsPkce { get; } = false;
        public override bool SupportsCustomUrlScheme { get; } = false;
        public override char ScopeDelimiter { get; } = ' ';
    }
}
