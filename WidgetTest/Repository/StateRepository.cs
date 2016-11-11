// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="StateRepository.cs" company="Conrad Enterprise, Inc.">
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
    /// Class StateRepository.
    /// </summary>
    /// <seealso cref="WidgetTest.Repository.GenericRepository{WidgetTest.Models.State}" />
    /// <seealso cref="WidgetTest.Repository.IStateRepository" />
    public class StateRepository : GenericRepository<State>, IStateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateRepository"/> class.
        /// </summary>
        public StateRepository()
        { }

        /// <summary>
        /// News this instance.
        /// </summary>
        /// <returns>StateRepository.</returns>
        public StateRepository New()
        {
            return new StateRepository();
        }
    }
}