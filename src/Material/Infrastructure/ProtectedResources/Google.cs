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
    /// Google API 1
    /// </summary>
    [CredentialType(typeof(OAuth2Credentials))]
	public partial class Google : OAuth2ResourceProvider              
	{
        public override List<String> AvailableScopes => new List<String> { "https://www.googleapis.com/auth/gmail.readonly", "https://www.googleapis.com/auth/userinfo.email", "https://www.googleapis.com/auth/analytics.readonly" };
        public override List<ResponseTypeEnum> Flows => new List<ResponseTypeEnum> { ResponseTypeEnum.Code, ResponseTypeEnum.Token };
        public override List<GrantTypeEnum> GrantTypes => new List<GrantTypeEnum> { GrantTypeEnum.AuthCode, GrantTypeEnum.RefreshToken };
        public override String TokenName => "Bearer";
        public override Uri AuthorizationUrl => new Uri("https://accounts.google.com/o/oauth2/auth");
        public override Uri TokenUrl => new Uri("https://accounts.google.com/o/oauth2/token");
	}
}
