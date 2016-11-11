// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="BaseRepository.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Configuration;
using System.IO;
using WidgetTest.Classes;

namespace WidgetTest.Repository
{
    /// <summary>
    /// Class BaseRepository.
    /// </summary>
    public abstract class BaseRepository 
    {
        /// <summary>
        /// The rest service
        /// </summary>
        protected readonly string RestService = ConfigurationManager.AppSettings["restService"];
        /// <summary>
        /// The request method
        /// </summary>
        protected readonly RequestMethod RequestMethod = new RequestMethod();
        /// <summary>
        /// The _serializer
        /// </summary>
        private readonly ISerialization _serializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository"/> class.
        /// </summary>
        protected BaseRepository()
        {
            // Dependency Injection is not working for some reason so I an newing up a new serializer here.  1/8/2015
            _serializer = new JsonNetSerialization();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository"/> class.
        /// </summary>
        /// <param name="serializer">The serializer.</param>
        protected BaseRepository(ISerialization serializer)
        {
            _serializer = serializer;
        }

        /// <summary>
        /// Des the serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Object.</returns>
        protected object deSerialize<T>(Stream stream)
        {
            var retval = _serializer.DeSerialize<T>(stream);
            return retval;
        }

        /// <summary>
        /// Serializes the specified value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        protected string serialize<T>(T value)
        {
            var retval = _serializer.Serialize<T>(value);
            return retval;
        }
    }
}