// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="TestDiscountDbSet.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using WidgetTestService.Models;

namespace WidgetTestService.Tests
{
    /// <summary>
    /// Class TestDiscountDbSet.
    /// </summary>
    /// <seealso cref="WidgetTestService.Tests.TestDbSet{WidgetTestService.Models.Discount}" />
    class TestDiscountDbSet : TestDbSet<Discount>
    {
        /// <summary>
        /// Finds an entity with the given primary key values.
        /// If an entity with the given primary key values exists in the context, then it is
        /// returned immediately without making a request to the store.  Otherwise, a request
        /// is made to the store for an entity with the given primary key values and this entity,
        /// if found, is attached to the context and returned.  If no entity is found in the
        /// context or the store, then null is returned.
        /// </summary>
        /// <param name="keyValues">The values of the primary key for the entity to be found.</param>
        /// <returns>The entity found, or null.</returns>
        /// <remarks>The ordering of composite key values is as defined in the EDM, which is in turn as defined in
        /// the designer, by the Code First fluent API, or by the DataMember attribute.</remarks>
        public override Discount Find(params object[] keyValues)
        {
            return this.SingleOrDefault(s => s.DiscountId == (int)keyValues.Single());
        }
    }
}
