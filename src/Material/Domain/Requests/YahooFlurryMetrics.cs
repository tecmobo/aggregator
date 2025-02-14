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
using Material.Domain.Requests;
using Material.Framework.Metadata.Formatters;
using Material.Domain.Core;
using System.CodeDom.Compiler;

namespace Material.Domain.Requests
{     
    /// <summary>
    /// The API request comprises of elements that can be combined to query your analytics data.
    /// </summary>
    [ServiceType(typeof(YahooFlurry))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class YahooFlurryMetrics : OAuthRequest              
	{
        public override String Host => "https://api-metrics.flurry.com";
        public override String Path => "/public/v1/data/{table}/{timeGrain}/{dimensions}";
        public override String HttpMethod => "GET";
        public override List<MediaType> Produces => new List<MediaType> { MediaType.Json };
        public override List<MediaType> Consumes => new List<MediaType> { MediaType.Json };
        public override List<HttpStatusCode> ExpectedStatusCodes => new List<HttpStatusCode> { HttpStatusCode.OK };
        /// <summary>
        /// 
        /// </summary>
        [Name("table")]
        [ParameterType(RequestParameterType.Path)]
        [Required()]
        [EnumFormatter()]
        public  Nullable<YahooFlurryMetricsTable> Table { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("timeGrain")]
        [ParameterType(RequestParameterType.Path)]
        [Required()]
        [EnumFormatter()]
        public  Nullable<YahooFlurryMetricsTimeGrain> TimeGrain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("dimensions")]
        [ParameterType(RequestParameterType.Path)]
        [Required()]
        [DefaultFormatter()]
        public  String Dimensions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("metrics")]
        [ParameterType(RequestParameterType.Query)]
        [Required()]
        [DefaultFormatter()]
        public  String Metrics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("dateTime")]
        [ParameterType(RequestParameterType.Query)]
        [Required()]
        [DefaultFormatter()]
        public  String DateTime { get; set; }
	}
	
	[GeneratedCode("T4Toolbox", "14.0")]
    public enum YahooFlurryMetricsTable
    {
        [Description("appUsage")] AppUsage,
        [Description("appEvent")] AppEvent,
        [Description("realtime")] Realtime,
    }
	
	[GeneratedCode("T4Toolbox", "14.0")]
    public enum YahooFlurryMetricsTimeGrain
    {
        [Description("day")] Day,
        [Description("week")] Week,
        [Description("month")] Month,
        [Description("all")] All,
    }
}
