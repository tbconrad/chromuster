// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-11-2016
// ***********************************************************************
// <copyright file="GenericRepository.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;

namespace WidgetTest.Repository
{

    /// <summary>
    /// Class GenericRepository.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="WidgetTest.Repository.BaseRepository" />
    /// <seealso cref="WidgetTest.Repository.IGenericRepository{T}" />
    public abstract class GenericRepository<T> : BaseRepository, IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IQueryable&lt;T&gt;.</returns>
        public IQueryable<T> GetAll()
        {
            var responseStream =
                RequestMethod.GetResponseStream(
                    RequestMethod.getRequest("GET", "application/json",
                        $"{RestService}/api/{typeof(T).Name}/").GetResponse());

            List<T> collection = deSerialize<List<T>>(responseStream) as List<T>;

            return collection.AsQueryable();
        }

        /// <summary>
        /// Gets the single.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>T.</returns>
        public T GetSingle(int value)
        {
            var responseStream =
                RequestMethod.GetResponseStream(
                    RequestMethod.getRequest("GET", "application/json",
                        $"{RestService}/api/{typeof(T).Name}/{value}").GetResponse());

            T query = deSerialize<T>(responseStream) as T;

            return query;
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(T entity)
        {
            String json = serialize<T>(entity);
            RequestMethod.getRequest("POST", "application/json", $"{RestService}/api/{typeof(T).Name}/", json)
                .GetResponse();
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Delete(int value)
        {
            RequestMethod.GetResponseStream(
                RequestMethod.getRequest("DELETE", "application/json",
                    $"{RestService}/api/{typeof(T).Name}/{value}").GetResponse());
        }

        /// <summary>
        /// Saves the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="value">The value.</param>
        public void Save(T entity, int value)
        {
            String json = serialize<T>(entity);
            RequestMethod.getRequest("PUT", "application/json",
                $"{RestService}/api/{typeof(T).Name}/{value}", json).GetResponse();
        }
    }
}