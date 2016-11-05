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
	public partial class Rescuetime : OAuth2ResourceProvider              
	{
        public override List<String> AvailableScopes => new List<String> { "time_data" };
        public override List<OAuth2ResponseType> Flows => new List<OAuth2ResponseType> { OAuth2ResponseType.Code };
        public override List<GrantType> GrantTypes => new List<GrantType> { GrantType.AuthCode };
        public override String TokenName => "access_token";
        public override Uri AuthorizationUrl => new Uri("https://www.rescuetime.com/oauth/authorize");
        public override Uri TokenUrl => new Uri("https://www.rescuetime.com/oauth/token");
	}
}
