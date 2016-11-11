// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="Widget.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Class Widget.
    /// </summary>
    public class Widget : BaseEntity, IWidget
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int WidgetId { get; set; }
        /// <summary>
        /// Gets or sets the widget name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the base price of the widget.
        /// </summary>
        /// <value>The base price.</value>
        public double BasePrice { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Widget"/> can be discounted.
        /// </summary>
        /// <value><c>true</c> if discount; otherwise, <c>false</c>.</value>
        public bool? DiscountAvailable { get; set; }

        /// <summary>
        /// Gets or sets the discount identifier.
        /// </summary>
        /// <value>The discount identifier.</value>
        public int? DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>The discount.</value>
        public Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Widget"/> is active.
        /// </summary>
        /// <value><c>null</c> if [active] contains no value, <c>true</c> if [active]; otherwise, <c>false</c>.</value>
        public Boolean? Active { get; set; } = true;

        /// <summary>
        /// Gets the name and price.
        /// </summary>
        /// <value>The name and price.</value>
        public string NameAndPrice => Name + "   -   " + this.BasePrice;
    }
}