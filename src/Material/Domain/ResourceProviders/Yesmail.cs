﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Material.Domain.Credentials;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Material.Framework.Enums;
using Material.Framework.Metadata;
using Material.Domain.Core;

namespace Material.Domain.ResourceProviders
{     
    /// <summary>
    /// Yesmail API v2.0
    /// </summary>
	[GeneratedCode("T4Toolbox", "14.0")]
	public partial class Yesmail : ApiKeyResourceProvider 
    {
        public override string KeyName { get; } = "api-key";
        public override HttpParameterType KeyType { get; } = HttpParameterType.Header;
    }
}
