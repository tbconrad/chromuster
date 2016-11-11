// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="ITaxRate.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface ITaxRate
    /// </summary>
    /// <seealso cref="WidgetTest.Models.IBaseEntity" />
    public interface ITaxRate : IBaseEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ITaxRate"/> is active.
        /// </summary>
        /// <value><c>null</c> if [active] contains no value, <c>true</c> if [active]; otherwise, <c>false</c>.</value>
        bool? Active { get; set; }
        /// <summary>
        /// Gets or sets the tax base rate.
        /// </summary>
        /// <value>The tax base rate.</value>
        double TaxBaseRate { get; set; }
        /// <summary>
        /// Gets or sets the tax rate identifier.
        /// </summary>
        /// <value>The tax rate identifier.</value>
        int TaxRateId { get; set; }
    }
}