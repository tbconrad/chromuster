// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="IState.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace WidgetTest.Models
{
    /// <summary>
    /// Interface IState
    /// </summary>
    /// <seealso cref="WidgetTest.Models.IBaseEntity" />
    public interface IState : IBaseEntity
    {
        /// <summary>
        /// Gets or sets the state abbreviation.
        /// </summary>
        /// <value>The state abbreviation.</value>
        string StateAbbreviation { get; set; }
        /// <summary>
        /// Gets or sets the state identifier.
        /// </summary>
        /// <value>The state identifier.</value>
        int StateId { get; set; }
        /// <summary>
        /// Gets or sets the name of the state.
        /// </summary>
        /// <value>The name of the state.</value>
        string StateName { get; set; }
        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        /// <value>The tax rate.</value>
        TaxRate TaxRate { get; set; }
        /// <summary>
        /// Gets or sets the tax rate identifier.
        /// </summary>
        /// <value>The tax rate identifier.</value>
        int TaxRateId { get; set; }
    }
}