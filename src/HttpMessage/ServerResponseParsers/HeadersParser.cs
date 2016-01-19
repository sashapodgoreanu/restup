﻿using Devkoes.HttpMessage.Models.Contracts;
using System;
using System.Text;

namespace Devkoes.HttpMessage.ServerResponseParsers
{
    internal class HeadersParser : IHttpResponsePartParser
    {
        public byte[] ParseToBytes(HttpServerResponse response)
        {
            throw new NotImplementedException();
        }

        public string ParseToString(HttpServerResponse response)
        {
            var headersTextBuilder = new StringBuilder();
            foreach (var header in response.Headers)
            {
                headersTextBuilder.Append($"{header.Name}: {header.Value}\r\n");
            }

            headersTextBuilder.Append("\r\n");

            return headersTextBuilder.ToString();
        }
    }
}
