// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="JsonNetSerialization.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;
using Newtonsoft.Json;
using WidgetTest.Repository;

namespace WidgetTest.Classes
{
    /// <summary>
    /// Class JsonNetSerialization.
    /// </summary>
    /// <seealso cref="WidgetTest.Repository.ISerialization" />
    public class JsonNetSerialization : ISerialization
    {
        /// <summary>
        /// Serializes the specified o.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o">The o.</param>
        /// <returns>System.String.</returns>
        public string Serialize<T>(object o)
        {
            return JsonConvert.SerializeObject((T)o);
        }

        /// <summary>
        /// Des the serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Object.</returns>
        public object DeSerialize<T>(Stream stream)
        {
            return JsonConvert.DeserializeObject<T>(new StreamReader(stream).ReadToEnd());
        }
    }
}