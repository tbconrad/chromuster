// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="DiscountRepository.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using WidgetTest.Models;

namespace WidgetTest.Repository
{

#pragma warning disable CS1584
#pragma warning disable CS1658
    /// <summary>
    /// Class DiscountRepository.
    /// </summary>
    /// <seealso cref="WidgetTest.Repository.GenericRepository{WidgetTest.Models.Discount}" />
    /// <seealso cref="WidgetTest.Repository.IDiscountRepository" />
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountRepository"/> class.
        /// </summary>
        public DiscountRepository()
        { }

        /// <summary>
        /// News this instance.
        /// </summary>
        /// <returns>DiscountRepository.</returns>
        public DiscountRepository New()
        {
            return new DiscountRepository();
        }
    }
}