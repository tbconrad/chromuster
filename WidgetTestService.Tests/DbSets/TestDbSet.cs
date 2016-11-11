// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="TestDbSet.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;

namespace WidgetTestService.Tests
{
    /// <summary>
    /// Class TestDbSet.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Data.Entity.DbSet{T}" />
    /// <seealso cref="System.Linq.IQueryable" />
    /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
    public class TestDbSet<T> : DbSet<T>, IQueryable, IEnumerable<T>
        where T : class
    {
        /// <summary>
        /// The data
        /// </summary>
        ObservableCollection<T> _data;
        /// <summary>
        /// The query
        /// </summary>
        IQueryable _query;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDbSet{T}"/> class.
        /// </summary>
        public TestDbSet()
        {
            _data = new ObservableCollection<T>();
            _query = _data.AsQueryable();
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>T.</returns>
        public override T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>T.</returns>
        public override T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        /// <summary>
        /// Attaches the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>T.</returns>
        public override T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>T.</returns>
        /// <inheritdoc />
        public override T Create()
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <typeparam name="TDerivedEntity">The type of the t derived entity.</typeparam>
        /// <returns>TDerivedEntity.</returns>
        /// <inheritdoc />
        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        /// <summary>
        /// Gets the local.
        /// </summary>
        /// <value>The local.</value>
        /// <inheritdoc />
        public override ObservableCollection<T> Local
        {
            get { return new ObservableCollection<T>(_data); }
        }

        /// <summary>
        /// Gets the type of the element(s) that are returned when the expression tree associated with this instance of <see cref="T:System.Linq.IQueryable" /> is executed.
        /// </summary>
        /// <value>The type of the element.</value>
        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        /// <summary>
        /// Gets the expression tree that is associated with the instance of <see cref="T:System.Linq.IQueryable" />.
        /// </summary>
        /// <value>The expression.</value>
        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        /// <summary>
        /// Gets the query provider that is associated with this data source.
        /// </summary>
        /// <value>The provider.</value>
        IQueryProvider IQueryable.Provider
        {
            get { return _query.Provider; }
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }
    }
}
