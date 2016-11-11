// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-11-2016
// ***********************************************************************
// <copyright file="IGenericRepository.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Linq;

namespace WidgetTest.Repository
{
    /// <summary>
    /// Interface IGenericRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IQueryable&lt;T&gt;.</returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// Gets the single.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>T.</returns>
        T GetSingle(int value);
        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(T entity);
        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="value">The value.</param>
        void Delete(int value);
        /// <summary>
        /// Saves the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="value">The value.</param>
        void Save(T entity, int value);
    }
}