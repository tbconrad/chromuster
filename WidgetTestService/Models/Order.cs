// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="Order.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WidgetTestService.Models
{
    /// <summary>
    /// Class Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int OrderId { get; set; }
        /// <summary>
        /// Gets or sets the widget identifier.
        /// </summary>
        /// <value>The widget identifier.</value>
        [Required]
        public int WidgetId { get; set; }
        /// <summary>
        /// Gets or sets the widget.
        /// </summary>
        /// <value>The widget.</value>
        [ForeignKey("WidgetId")]
        public Widget Widget { get; set; }
        /// <summary>
        /// Gets or sets the state identifier.
        /// </summary>
        /// <value>The state identifier.</value>
        [Required]
        public int StateId { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [ForeignKey("StateId")]

        public State State { get; set; }
        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        /// <value>The order date.</value>
        [Required]
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        public int Quantity { get; set; }
    }
}