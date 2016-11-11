// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="WidgetControllerRequestMethod.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;
using System.Net;
using System.Text;

namespace WidgetTest.Repository
{
    /// <summary>
    /// Class RequestMethod.
    /// </summary>
    public class RequestMethod
    {
        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="endPoint">The end point.</param>
        /// <param name="content">The content.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>WebRequest.</returns>
        public WebRequest getRequest(string method, string contentType, string endPoint, string content, int timeout = 100000)
        {
            var request = this.getRequest(method, contentType, endPoint);
            var dataArray = Encoding.UTF8.GetBytes(content.ToString());
            request.ContentLength = dataArray.Length;
            var requestStream = request.GetRequestStream();
            requestStream.Write(dataArray, 0, dataArray.Length);
            requestStream.Flush();
            requestStream.Close();
            request.Timeout = timeout;
            return request;
        }

        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="endPoint">The end point.</param>
        /// <returns>WebRequest.</returns>
        public WebRequest getRequest(string method, string contentType, string endPoint)
        {
            var request = WebRequest.Create(endPoint);
            request.Method = method;
            request.ContentType = contentType;

            return request;
        }

        /// <summary>
        /// Gets the response stream.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Stream.</returns>
        public Stream GetResponseStream(WebResponse response)
        {
            return response.GetResponseStream();
        }

        /// <summary>
        /// Gets the response reader.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>StreamReader.</returns>
        public StreamReader GetResponseReader(WebResponse response)
        {
            return new StreamReader(GetResponseStream(response));
        }

        /// <summary>
        /// Uns the pack response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>System.String.</returns>
        public string unPackResponse(WebResponse response)
        {
            return GetResponseReader(response).ReadToEnd();
        }
    }
}