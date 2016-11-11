// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="IOrderRepository.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using WidgetTest.Models;

namespace WidgetTest.Repository
{
    /// <summary>
    /// Interface IOrderRepository
    /// </summary>
    public interface IOrderRepository : IGenericRepository<Order>
    {
        /// <summary>
        /// News this instance.
        /// </summary>
        /// <returns>OrderRepository.</returns>
        OrderRepository New();
    }
}