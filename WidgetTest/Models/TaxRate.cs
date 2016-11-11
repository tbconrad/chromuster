// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="TaxRate.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Class TaxRate.
    /// </summary>
    public class TaxRate : BaseEntity, ITaxRate
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int TaxRateId { get; set; }
        /// <summary>
        /// Gets or sets the discount percentage rate.
        /// </summary>
        /// <value>The discount.</value>
        public double TaxBaseRate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TaxRate"/> is active.
        /// </summary>
        /// <value><c>null</c> if [active] contains no value, <c>true</c> if [active]; otherwise, <c>false</c>.</value>
        public Boolean? Active { get; set; }
    }
}