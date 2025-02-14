﻿using Material.Framework.Metadata;

namespace Material.Framework.Enums
{
    public enum MediaType
    {
        [Description("")]
        Undefined,
        [Description("application/json")]
        Json,
        [Description("application/xml")]
        Xml,
        [Description("text/json")]
        TextJson,
        [Description("text/x-json")]
        TextXJson,
        [Description("text/xml")]
        TextXml,
        [Description("text/plain")]
        Text,
        [Description("text/html")]
        Html,
        [Description("text/javascript")]
        Javascript,
        [Description("application/x-www-form-urlencoded")]
        Form,
        [Description("application/jwt")]
        JsonWebToken,
        [Description("audio/wav")]
        Wave,
        [Description("application/vnd.com.runkeeper.FitnessActivityFeed+json")]
        RunkeeperFitnessActivity
    }
}
