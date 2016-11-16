// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="IBaseEntity.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface IBaseEntity
    /// </summary>
    public interface IBaseEntity
    {
        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>The created.</value>
        DateTime Created { get; set; }
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        string CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the modified.
        /// </summary>
        /// <value>The modified.</value>
        DateTime? Modified { get; set; }
    }
}