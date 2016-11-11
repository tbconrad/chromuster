// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="IDiscount.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface IDiscount
    /// </summary>
    /// <seealso cref="WidgetTest.Models.IBaseEntity" />
    public interface IDiscount : IBaseEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IDiscount"/> is active.
        /// </summary>
        /// <value><c>null</c> if [active] contains no value, <c>true</c> if [active]; otherwise, <c>false</c>.</value>
        bool? Active { get; set; }
        /// <summary>
        /// Gets or sets the discount identifier.
        /// </summary>
        /// <value>The discount identifier.</value>
        int DiscountId { get; set; }
        /// <summary>
        /// Gets or sets the discount percentage.
        /// </summary>
        /// <value>The discount percentage.</value>
        int DiscountPercentage { get; set; }
    }
}