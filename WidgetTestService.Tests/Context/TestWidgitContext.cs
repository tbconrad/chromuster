// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="TestWidgitContext.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data.Entity;
using WidgetTestService.DAL;
using WidgetTestService.Models;

namespace WidgetTestService.Tests
{
    /// <summary>
    /// Class TestWidgitContext.
    /// </summary>
    /// <seealso cref="WidgetTestService.DAL.IWidgetContext" />
    class TestWidgitContext : IWidgetContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestWidgitContext"/> class.
        /// </summary>
        public TestWidgitContext()
        {
            this.Widgets = new TestWidgetDbSet();
            this.Discounts = new TestDiscountDbSet();
            this.States = new TestStateDbSet();
            this.TaxRates = new TestTaxRateDbSet();
            this.Orders = new TestOrderDbSet();
        }

        /// <summary>
        /// Gets or sets the widgets.
        /// </summary>
        /// <value>The widgets.</value>
        public DbSet<Widget> Widgets { get; set; }
        /// <summary>
        /// Gets or sets the discounts.
        /// </summary>
        /// <value>The discounts.</value>
        public DbSet<Discount> Discounts { get; set; }
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>The states.</value>
        public DbSet<State> States { get; set; }
        /// <summary>
        /// Gets or sets the tax rates.
        /// </summary>
        /// <value>The tax rates.</value>
        public DbSet<TaxRate> TaxRates { get; set; }
        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>The orders.</value>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Saves the changes.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int SaveChanges() { return 0; }
        /// <summary>
        /// Marks as modified.
        /// </summary>
        /// <typeparam name="TE">The type of the te.</typeparam>
        /// <param name="entity">The entity.</param>
        public void MarkAsModified<TE>(TE entity) where TE : class { }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() { }
    }
}
