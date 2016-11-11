// ***********************************************************************
// Assembly         : WidgetTestService
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
using System.ComponentModel.DataAnnotations;

namespace WidgetTestService.Models
{
    /// <summary>
    /// Class Widget.
    /// </summary>
    public class Widget
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int WidgetId { get; set; }
        /// <summary>
        /// Gets or sets the widget name.
        /// </summary>
        /// <value>The name.</value>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the base price of the widget.
        /// </summary>
        /// <value>The base price.</value>
        [Required]
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
        /// Gets or sets the name of the user the entry was created by.
        /// </summary>
        /// <value>The created by.</value>
        [Required]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the date the entry was created.
        /// </summary>
        /// <value>The created.</value>
        [Required]
        public DateTime Created { get; set; }
        /// <summary>
        /// Gets or sets the date the entry modified.
        /// </summary>
        /// <value>The modified.</value>
        public DateTime? Modified { get; set; }
    }
}