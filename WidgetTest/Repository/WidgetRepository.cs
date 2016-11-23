// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="WidgetRepository.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using WidgetTest.Models;

namespace WidgetTest.Repository
{

//#pragma warning disable CS1584
//#pragma warning disable CS1658
    // XML comment has syntactically incorrect cref attribute
    /// <summary>
    /// Class WidgetRepository.
    /// </summary>
    /// <seealso cref="WidgetTest.Repository.GenericRepository{WidgetTest.Models.Widget}" />
    /// <seealso cref="WidgetTest.Repository.IWidgetRepository" />
    public class WidgetRepository : GenericRepository<Widget>, IWidgetRepository
#pragma warning restore CS1584 // XML comment has syntactically incorrect cref attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetRepository"/> class.
        /// </summary>
        public WidgetRepository()
        { }

    }
}