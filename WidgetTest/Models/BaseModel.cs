// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-15-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-15-2016
// ***********************************************************************
// <copyright file="BaseModel.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;

namespace WidgetTest.Models
{
    /// <summary>
    /// Class BaseModel.
    /// </summary>
    /// <seealso cref="WidgetTest.Models.IBaseModel" />
    public class BaseModel : IBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        public BaseModel()
        {
            Success = false;
            ResultCode = 0;
            Errors = new List<string>();
        }
        /// <summary>
        /// Gets a value indicating whether this <see cref="IBaseEntity" /> is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        public bool Success { get; set; }
        /// <summary>
        /// Gets the result code.
        /// </summary>
        /// <value>The result code.</value>
        public int ResultCode { get; set; }
        /// <summary>
        /// Gets the errors.
        /// </summary>
        /// <value>The errors.</value>
        public IList<string> Errors { get; private set; }
        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="error">The error.</param>
        public void AddError(string error)
        {
            Errors.Add(error);
        }
    }
}