// ***********************************************************************
// Assembly         : WidgetTest
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


namespace WidgetTest.Models
{
    /// <summary>
    /// Class State.
    /// </summary>
    public class State : BaseEntity, IState
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int StateId { get; set; }
        /// <summary>
        /// Gets or sets the name of the state.
        /// </summary>
        /// <value>The name of the state.</value>
        public string StateName { get; set; }
        /// <summary>
        /// Gets or sets the state abbreviation.
        /// </summary>
        /// <value>The state abbreviation.</value>
        public string StateAbbreviation { get; set; }

        /// <summary>
        /// Gets the tax rate identifier.
        /// </summary>
        /// <value>The tax rate identifier.</value>
        public int TaxRateId { get; set; } = 18;
        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        /// <value>The tax rate.</value>
        public TaxRate TaxRate { get; set; }
    }
}