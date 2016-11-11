// ***********************************************************************
// Assembly         : WidgetTestService
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
using System.ComponentModel.DataAnnotations;

namespace WidgetTestService.Models
{
    /// <summary>
    /// Class TaxRate.
    /// </summary>
    public class TaxRate
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int TaxRateId { get; set; }
        /// <summary>
        /// Gets or sets the Tax Rate .
        /// </summary>
        /// <value>The discount.</value>
        [Required]
        public double TaxBaseRate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TaxRate"/> is active.
        /// </summary>
        /// <value><c>null</c> if [active] contains no value, <c>true</c> if [active]; otherwise, <c>false</c>.</value>
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