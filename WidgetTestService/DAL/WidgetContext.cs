// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="WidgetContext.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using WidgetTestService.Models; 
using System.Data.Entity;

namespace WidgetTestService.DAL
{
    /// <summary>
    /// Class WidgetContext.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class WidgetContext : DbContext, IWidgetContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetContext"/> class.
        /// </summary>
        public WidgetContext() : base("WidgetTestConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WidgetContext, Migrations.Configuration>("WidgetTestConnectionString"));
        }

        /// <summary>
        /// Gets or sets the widgets.
        /// </summary>
        /// <value>The widgets.</value>
        public DbSet<Widget> Widgets { get; set; }
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>The states.</value>
        public DbSet<State> States { get; set; }
        /// <summary>
        /// Gets or sets the discounts.
        /// </summary>
        /// <value>The discounts.</value>
        public DbSet<Discount> Discounts { get; set; }
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
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.</remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Properties()
                .Where(p => p.Name == p.DeclaringType.Name + "Id")
                .Configure(p => p.IsKey());

            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// Generic method to mark the entity as modified.
        /// </summary>
        /// <typeparam name="TE">The type of the te.</typeparam>
        /// <param name="entity">The entity.</param>
        public void MarkAsModified<TE>(TE entity) where TE : class 
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}