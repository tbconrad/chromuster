// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="State.cs" company="Conrad Enterprise, Inc.">
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
    /// Class State.
    /// </summary>
    public class State
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int StateId { get; set; }
        /// <summary>
        /// Gets or sets the name of the state.
        /// </summary>
        /// <value>The name of the state.</value>
        [Required]
        public string StateName { get; set; }
        /// <summary>
        /// Gets or sets the state abbreviation.
        /// </summary>
        /// <value>The state abbreviation.</value>
        [MaxLength(2)]
        [Required]
        public string StateAbbreviation { get; set; }
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

        /// <summary>
        /// Gets the tax rate identifier.
        /// </summary>
        /// <value>The tax rate identifier.</value>
        public int TaxRateId { get; set; } = 18;
        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        /// <value>The tax rate.</value>
        [ForeignKey("TaxRateId")]
        public virtual TaxRate TaxRate { get; set; }

    }
}