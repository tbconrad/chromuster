// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-15-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-15-2016
// ***********************************************************************
// <copyright file="IBaseModel.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface IBaseModel
    /// </summary>
    public interface IBaseModel
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="IBaseEntity" /> is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        bool Success { get; set; }

        /// <summary>
        /// Gets the result code.
        /// </summary>
        /// <value>The result code.</value>
        int ResultCode { get; set; }

        /// <summary>
        /// Gets the errors.
        /// </summary>
        /// <value>The errors.</value>
        IList<string> Errors { get; }

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="error">The error.</param>
        void AddError(string error);
    }
}