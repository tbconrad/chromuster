// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="Discount.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Class Discount.
    /// </summary>
    public class Discount : BaseEntity, IDiscount
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int DiscountId { get; set; }
        /// <summary>
        /// Gets or sets the discount percentage.
        /// </summary>
        /// <value>The discount percentage.</value>
        public int DiscountPercentage { get; set; }
        /// <summary>
        /// Gets or sets the indicator if this discount is active.
        /// </summary>
        /// <value>The active.</value>
        public Boolean? Active { get; set; }
    }
}