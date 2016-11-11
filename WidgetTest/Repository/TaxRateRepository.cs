// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="TaxRateRepository.cs" company="Conrad Enterprise, Inc.">
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
    /// Class TaxRateRepository.
    /// </summary>
    /// <seealso cref="WidgetTest.Repository.GenericRepository{WidgetTest.Models.TaxRate}" />
    /// <seealso cref="WidgetTest.Repository.ITaxRateRepository" />
    public class TaxRateRepository : GenericRepository<TaxRate>, ITaxRateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateRepository"/> class.
        /// </summary>
        public TaxRateRepository()
        { }

        /// <summary>
        /// News this instance.
        /// </summary>
        /// <returns>TaxRateRepository.</returns>
        public TaxRateRepository New()
        {
            return new TaxRateRepository();
        }
    }
}