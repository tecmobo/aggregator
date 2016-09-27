﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Material.Metadata;
using Material.Infrastructure.ProtectedResources;
using System;
using System.Collections.Generic;
using Material.Infrastructure;

namespace Material.Infrastructure.Requests
{     
    /// <summary>
    /// Returns the Analytics data
    /// </summary>
    [ServiceType(typeof(GoogleAnalytics))]
	public partial class GoogleAnalyticsReports : OAuthRequest              
	{
        public override String Host => "https://analyticsreporting.googleapis.com";
        public override String Path => "/v4/reports:batchGet";
        public override String HttpMethod => "POST";
        public override List<String> RequiredScopes => new List<String> { "https://www.googleapis.com/auth/analytics.readonly" };
	}
}
