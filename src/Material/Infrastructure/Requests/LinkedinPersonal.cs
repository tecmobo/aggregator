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
using Foundations.Enums;
using System.Net;
using Material.Infrastructure.Requests;
using Material.Enums;
using Material.Metadata.Formatters;
using Material.Infrastructure;
using Foundations.Attributes;
using System.CodeDom.Compiler;

namespace Material.Infrastructure.Requests
{     
    /// <summary>
    /// Basic profile data
    /// </summary>
    [ServiceType(typeof(LinkedIn))]
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class LinkedinPersonal : OAuthRequest              
	{
        public override String Host => "https://api.linkedin.com";
        public override String Path => "/v1/people/~";
        public override String HttpMethod => "GET";
        public override List<MediaType> Produces => new List<MediaType> { MediaType.Json };
        public override List<MediaType> Consumes => new List<MediaType> { MediaType.Json };
        public override List<HttpStatusCode> ExpectedStatusCodes => new List<HttpStatusCode> { HttpStatusCode.OK };
        public override List<String> RequiredScopes => new List<String> { "r_basicprofile" };
        /// <summary>
        /// the format of the response
        /// </summary>
        [Name("format")]
        [ParameterType(RequestParameterType.Query)]
        [EnumFormatter()]
        public  LinkedinPersonalFormat Format { get; set; } = LinkedinPersonalFormat.Json;
	}
	
	[GeneratedCode("T4Toolbox", "14.0")]
    public enum LinkedinPersonalFormat
    {
        [Description("json")] Json,
        [Description("xml")] Xml,
    }
}
