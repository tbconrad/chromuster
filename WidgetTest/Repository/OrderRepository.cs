// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="OrderRepository.cs" company="Conrad Enterprise, Inc.">
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
    /// Class OrderRepository.
    /// </summary>
    /// <seealso cref="WidgetTest.Repository.GenericRepository{WidgetTest.Models.Order}" />
    /// <seealso cref="WidgetTest.Repository.IOrderRepository" />
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRepository"/> class.
        /// </summary>
        public OrderRepository()
        { }

    }
}