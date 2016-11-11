// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="IWidgetContext.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data.Entity;
using WidgetTestService.Models;

namespace WidgetTestService.DAL
{
    /// <summary>
    /// Interface IWidgetContext
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IWidgetContext : IDisposable
    {
        /// <summary>
        /// Gets or sets the discounts.
        /// </summary>
        /// <value>The discounts.</value>
        DbSet<Discount> Discounts { get; set; }
        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>The orders.</value>
        DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>The states.</value>
        DbSet<State> States { get; set; }
        /// <summary>
        /// Gets or sets the tax rates.
        /// </summary>
        /// <value>The tax rates.</value>
        DbSet<TaxRate> TaxRates { get; set; }
        /// <summary>
        /// Gets or sets the widgets.
        /// </summary>
        /// <value>The widgets.</value>
        DbSet<Widget> Widgets { get; set; }
        /// <summary>
        /// Saves the changes.
        /// </summary>
        /// <returns>System.Int32.</returns>
        int SaveChanges();
        /// <summary>
        /// Marks as modified.
        /// </summary>
        /// <typeparam name="TE">The type of the te.</typeparam>
        /// <param name="entity">The entity.</param>
        void MarkAsModified<TE>(TE entity) where TE : class;
    }
}