﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Material.Framework.Metadata;
using Material.Domain.ResourceProviders;
using System;
using System.Collections.Generic;
using Material.Framework.Enums;
using System.Net;
using Material.Framework.Metadata.Formatters;
using Material.Domain.Core;
using System.CodeDom.Compiler;

namespace Material.Domain.Requests
{     
    /// <summary>
    /// The Get Activity Time Series endpoint returns time series data for a specific date
    /// </summary>
    [ServiceType(typeof(Fitbit))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class FitbitIntradayStepsBulk : OAuthRequest              
	{
        public override String Host => "https://api.fitbit.com";
        public override String Path => "/1/user/-/activities/steps/date/{date}/1d/1min.json";
        public override String HttpMethod => "GET";
        public override List<MediaType> Produces => new List<MediaType> { MediaType.Json };
        public override List<MediaType> Consumes => new List<MediaType> { MediaType.Json };
        public override List<HttpStatusCode> ExpectedStatusCodes => new List<HttpStatusCode> { HttpStatusCode.OK };
        public override List<String> RequiredScopes => new List<String> { "activity" };
        /// <summary>
        /// The date, in the format yyyy-MM-dd or today
        /// </summary>
        [Name("date")]
        [ParameterType(RequestParameterType.Path)]
        [Required()]
        [DateTimeFormatter("yyyy-MM-dd")]
        public  Nullable<DateTime> Date { get; set; }
	}
}
