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
    /// Get list of sessions a user has
    /// </summary>
    [ServiceType(typeof(XamarinInsights))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class XamarinInsightsSessions : OAuthRequest              
	{
        public override String Host => "https://insights.xamarin.com";
        public override String Path => "/api/users/{appId}/sessions";
        public override String HttpMethod => "GET";
        public override List<MediaType> Produces => new List<MediaType> { MediaType.Json };
        public override List<MediaType> Consumes => new List<MediaType> { MediaType.Json };
        public override List<HttpStatusCode> ExpectedStatusCodes => new List<HttpStatusCode> { HttpStatusCode.OK };
        /// <summary>
        /// Id of the app
        /// </summary>
        [Name("appId")]
        [ParameterType(RequestParameterType.Path)]
        [Required()]
        [DefaultFormatter()]
        public  String AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("userid")]
        [ParameterType(RequestParameterType.Query)]
        [Required()]
        [DefaultFormatter()]
        public  String Userid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("deviceid")]
        [ParameterType(RequestParameterType.Query)]
        [Required()]
        [DefaultFormatter()]
        public  String Deviceid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Name("limit")]
        [ParameterType(RequestParameterType.Query)]
        [DefaultFormatter()]
        public  Nullable<Int32> Limit { get; set; } = 200;
	}
}
