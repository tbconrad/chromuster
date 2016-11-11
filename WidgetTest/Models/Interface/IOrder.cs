// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="IOrder.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface IOrder
    /// </summary>
    public interface IOrder : IBaseEntity
    {
        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>The discount.</value>
        Discount Discount { get; set; }
        /// <summary>
        /// Gets or sets the discount identifier.
        /// </summary>
        /// <value>The discount identifier.</value>
        int DiscountId { get; set; }
        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        /// <value>The order date.</value>
        DateTime OrderDate { get; set; }
        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        int OrderId { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        State State { get; set; }
        /// <summary>
        /// Gets or sets the state identifier.
        /// </summary>
        /// <value>The state identifier.</value>
        int StateId { get; set; }
        /// <summary>
        /// Gets or sets the widget.
        /// </summary>
        /// <value>The widget.</value>
        Widget Widget { get; set; }
        /// <summary>
        /// Gets or sets the widget identifier.
        /// </summary>
        /// <value>The widget identifier.</value>
        int WidgetId { get; set; }
    }
}