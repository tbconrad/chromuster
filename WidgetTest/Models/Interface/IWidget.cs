// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="IWidget.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface IWidget
    /// </summary>
    /// <seealso cref="WidgetTest.Models.IBaseEntity" />
    public interface IWidget : IBaseEntity 
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IWidget"/> is active.
        /// </summary>
        /// <value><c>null</c> if [active] contains no value, <c>true</c> if [active]; otherwise, <c>false</c>.</value>
        bool? Active { get; set; }
        /// <summary>
        /// Gets or sets the base price.
        /// </summary>
        /// <value>The base price.</value>
        double BasePrice { get; set; }
        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>The discount.</value>
        Discount Discount { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [discount available].
        /// </summary>
        /// <value><c>null</c> if [discount available] contains no value, <c>true</c> if [discount available]; otherwise, <c>false</c>.</value>
        bool? DiscountAvailable { get; set; }
        /// <summary>
        /// Gets or sets the discount identifier.
        /// </summary>
        /// <value>The discount identifier.</value>
        int? DiscountId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }
        /// <summary>
        /// Gets the name and price.
        /// </summary>
        /// <value>The name and price.</value>
        string NameAndPrice { get; }
        /// <summary>
        /// Gets or sets the widget identifier.
        /// </summary>
        /// <value>The widget identifier.</value>
        int WidgetId { get; set; }
    }
}