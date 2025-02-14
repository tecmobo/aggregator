﻿using System;

namespace Material.Framework.Metadata
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CredentialTypeAttribute : Attribute
    {
        public Type TypeOfCredential { get; }

        public CredentialTypeAttribute(Type typeOfCredential)
        {
            TypeOfCredential = typeOfCredential;
        }
    }
}
