// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="ISerialization.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;

namespace WidgetTest.Repository
{
    /// <summary>
    /// Interface ISerialization
    /// </summary>
    public interface ISerialization
    {
        /// <summary>
        /// Serializes the specified o.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o">The o.</param>
        /// <returns>System.String.</returns>
        string Serialize<T>(object o);
        /// <summary>
        /// Des the serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Object.</returns>
        object DeSerialize<T>(Stream stream);
    }
}