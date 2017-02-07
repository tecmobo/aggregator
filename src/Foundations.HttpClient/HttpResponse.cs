﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Foundations.Collections;
using Foundations.Enums;
using Foundations.Extensions;
using Foundations.HttpClient.Enums;
using Foundations.HttpClient.Metadata;

namespace Foundations.HttpClient
{
    public class HttpResponse
    {
        public HttpStatusCode StatusCode { get; }
        public string Reason { get; }
        public IEnumerable<Cookie> Cookies { get; }
        public HttpResponseHeaders Headers { get; }

        private readonly HttpContent _content;
        private readonly MediaType _responseContentType;

        private readonly DefaultingDictionary<string, Encoding> _encodings =
            new DefaultingDictionary<string, Encoding>(s => Encoding.UTF8)
            {
                {ContentTypeEncoding.UTF16BigEndian.EnumToString(),
                    Encoding.BigEndianUnicode},
                {ContentTypeEncoding.UTF16LittleEndian.EnumToString(),
                    Encoding.Unicode}
            };

        public HttpResponse(
            HttpResponseMessage response,
            IEnumerable cookies)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));

            _content = response.Content;
            _responseContentType = response
                .Content
                ?.Headers
                ?.ContentType
                ?.MediaType
                ?.StringToEnum<MediaType>() ?? HttpConfiguration.DefaultResponseMediaType;
            Headers = response.Headers;
            StatusCode = response.StatusCode;
            Reason = response.ReasonPhrase;
            Cookies = cookies?.Cast<Cookie>();
        }

        public async Task<string> ContentAsync()
        {
            var buffer = await _content
                .ReadAsByteArrayAsync()
                .ConfigureAwait(false);

            return buffer.Length == 0 ? 
                string.Empty :
                _encodings[_content.Headers.ContentType.CharSet]
                    .GetString(buffer, 0, buffer.Length);
        }

        public async Task<T> ContentAsync<T>()
        {
            var result = await ContentAsync()
                .ConfigureAwait(false);

            var serializer = HttpConfiguration.ContentSerializers[
                _responseContentType];

            var datetimeFormatter = typeof(T)
                .GetCustomAttributes<DateTimeFormatterAttribute>()
                .FirstOrDefault()
                ?.Formatter;

            return serializer.Deserialize<T>(
                result, 
                datetimeFormatter);
        }
    }
}
