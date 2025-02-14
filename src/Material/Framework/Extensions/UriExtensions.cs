﻿using System;
using System.Globalization;
using System.Linq;
using Material.Framework.Collections;

namespace Material.Framework.Extensions
{
    public static class UriExtensions
    {
        public static string ToCorrectedString(this Uri instance)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));

            //System.Uri inserts an incorrect trailing slash after a scheme if no host name is
            //present, so if that happens remove that trailing slash
            return instance.ToString().Replace("///", "//");
        }

        /// <summary>
        /// Determines if the Uri's path is a subset of the given Uri's path
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="possibleMatch"></param>
        /// <returns></returns>
        public static bool IsSubpathOf(
            this Uri instance, 
            Uri possibleMatch)
        {
            if (instance == null || possibleMatch == null)
            {
                return false;
            } 

            return instance.AbsolutePath.TrimStart('/').StartsWith(
                possibleMatch.AbsolutePath.TrimStart('/'),
                StringComparison.Ordinal);
        }

        /// <summary>
        /// Gets a fragment of the uri containing the scheme and the host
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string NonPath(this Uri instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return string.Format(
                CultureInfo.InvariantCulture,
                "{0}://{1}/", 
                instance.Scheme, 
                instance.Authority);
        }

        /// <summary>
        /// Appends the given path onto the end of the current path
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Uri AddPath(
            this Uri instance,
            string path)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (path == null) throw new ArgumentNullException(nameof(path));

            var uriBuilder = new UriBuilder(instance);
            uriBuilder.Path = uriBuilder.Path.EndsWith(
                    "/", 
                    StringComparison.CurrentCultureIgnoreCase)
                ? uriBuilder.Path + path.TrimStart('/')
                : uriBuilder.Path + "/" + path.TrimStart('/');

            return uriBuilder.Uri;
        }

        /// <summary>
        /// Gets the last path segment from the Uri
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string GetEndOfPath(
            this Uri instance)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));

            return instance
                .AbsolutePath
                .Split('/')
                .ToList()
                .LastOrDefault();
        }

        /// <summary>
        /// Add parameters as a url encoded querystring
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        public static Uri AddEncodedQuerystring(
            this Uri instance,
            HttpValueCollection queryParameters)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (queryParameters == null) throw new ArgumentNullException(nameof(queryParameters));

            var querstring = queryParameters
                .EncodeParameters()
                .Concatenate("=", "&");

            var uriBuilder = new UriBuilder(instance)
            {
                Query = querstring
            };
            return uriBuilder.Uri;
        }
    }
}
