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

namespace Material.Infrastructure.ProtectedResources
{     
    /// <summary>
    /// Health Graph API 
    /// </summary>
    [CredentialType(typeof(OAuth2Credentials))]
	public partial class Runkeeper : OAuth2ResourceProvider              
	{
        public override List<String> AvailableScopes => new List<String>();
        public override List<ResponseTypeEnum> Flows => new List<ResponseTypeEnum> { ResponseTypeEnum.Code };
        public override List<GrantTypeEnum> GrantTypes => new List<GrantTypeEnum> { GrantTypeEnum.AuthCode };
        public override String TokenName => "Bearer";
        public override Uri AuthorizationUrl => new Uri("https://runkeeper.com/apps/authorize");
        public override Uri TokenUrl => new Uri("https://runkeeper.com/apps/token");
	}
}
