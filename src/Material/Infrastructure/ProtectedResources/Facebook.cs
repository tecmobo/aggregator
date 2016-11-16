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
    /// Facebook Graph API v2.7
    /// </summary>
    [CredentialType(typeof(OAuth2Credentials))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class Facebook : OAuth2ResourceProvider              
	{
        public override List<String> AvailableScopes => new List<String> { "email", "user_events", "user_likes", "user_friends", "user_posts" };
        public override List<OAuth2FlowType> AllowedFlows => new List<OAuth2FlowType> { OAuth2FlowType.AccessCode, OAuth2FlowType.Implicit };
        public override List<GrantType> AllowedGrantTypes => new List<GrantType> { GrantType.AuthCode };
        public override List<OAuth2ResponseType> AllowedResponseTypes => new List<OAuth2ResponseType> { OAuth2ResponseType.Code, OAuth2ResponseType.Token };
        public override String TokenName => "access_token";
        public override Char ScopeDelimiter => ',';
        public override Uri AuthorizationUrl => new Uri("https://www.facebook.com/dialog/oauth");
        public override Uri TokenUrl => new Uri("https://graph.facebook.com/oauth/access_token");
	}
}
