﻿using System;
using Material.Framework.Enums;
using Material.HttpClient.Authenticators;

namespace Material.Workflow.AuthenticatorParameters
{
    public class GenericParameter : IAuthenticatorParameter
    {
        public string Name { get; }
        public string Value { get; }
        public HttpParameterType Type { get; }

        public GenericParameter(
            string name, 
            string value, 
            HttpParameterType type)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (value == null) throw new ArgumentNullException(nameof(value));

            Name = name;
            Value = value;
            Type = type;
        }

        public GenericParameter(
            string name, 
            string value) : 
                this(
                    name, 
                    value, 
                    HttpParameterType.Unspecified)
        { }
    }
}
