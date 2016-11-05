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
    /// Omniture / Adobe Web API 1.4
    /// </summary>
    [CredentialType(typeof(OAuth2Credentials))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class Omniture : OAuth2ResourceProvider              
	{
        public override List<String> AvailableScopes => new List<String> { "Bookmark", "Company", "DataFeed", "DataWarehouse", "Permissions", "ReportSuite", "Saint", "Survey", "Dashboards", "DataSource", "Social", "Report", "Livestream" };
        public override List<OAuth2ResponseType> Flows => new List<OAuth2ResponseType> { OAuth2ResponseType.Code, OAuth2ResponseType.Token };
        public override List<GrantType> GrantTypes => new List<GrantType> { GrantType.AuthCode, GrantType.ClientCredentials };
        public override String TokenName => "Bearer";
        public override Uri AuthorizationUrl => new Uri("https://marketing.adobe.com/authorize");
        public override Uri TokenUrl => new Uri("https://api.omniture.com/token");
	}
}
