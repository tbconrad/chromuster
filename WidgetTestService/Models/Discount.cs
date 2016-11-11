// ***********************************************************************
// Assembly         : WidgetTestService
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
using System.ComponentModel.DataAnnotations;

namespace WidgetTestService.Models
{
    /// <summary>
    /// Class Discount.
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int DiscountId { get; set; }
        /// <summary>
        /// Gets or sets the discount percentage.
        /// </summary>
        /// <value>The discount percentage.</value>
        [Required]
        public int DiscountPercentage { get; set; }
        /// <summary>
        /// Gets or sets the indicator if this discount is active.
        /// </summary>
        /// <value>The active.</value>
        public Boolean? Active { get; set; }
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