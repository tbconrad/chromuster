// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="TaxRateControllerTest.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Net;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgetTestService.Controllers;
using WidgetTestService.Models;

namespace WidgetTestService.Tests.Controllers
{
    /// <summary>
    /// Class TaxRateControllerTest.
    /// </summary>
    [TestClass]
    public class TaxRateControllerTest
    {
        /// <summary>
        /// Gets the tax rate should return tax rate with same identifier.
        /// </summary>
        [TestMethod]
        public void GetTaxRate_ShouldReturnTaxRateWithSameId()
        {
            var context = new TestWidgitContext();
            context.TaxRates.Add(GetDemoTaxRate());

            var controller = new TaxRateController(context);
            var result = controller.Get(1) as OkNegotiatedContentResult<TaxRate>;

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Content.TaxRateId);
        }

        /// <summary>
        /// Gets the tax rates should return all tax rates.
        /// </summary>
        [TestMethod]
        public void GetTaxRates_ShouldReturnAllTaxRates()
        {
            var context = new TestWidgitContext();
            context.TaxRates.Add(new TaxRate { TaxRateId = 1, TaxBaseRate = 0.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });
            context.TaxRates.Add(new TaxRate { TaxRateId = 2, TaxBaseRate = 1.00, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });
            context.TaxRates.Add(new TaxRate { TaxRateId = 3, TaxBaseRate = 1.25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });

            var controller = new TaxRateController(context);
            var result = controller.Get() as TestTaxRateDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        /// <summary>
        /// Posts the tax rate should return same tax rate.
        /// </summary>
        [TestMethod]
        public void PostTaxRate_ShouldReturnSameTaxRate()
        {
            var controller = new TaxRateController(new TestWidgitContext());

            var item = GetDemoTaxRate();

            var result =
                controller.Post(item) as CreatedAtRouteNegotiatedContentResult<TaxRate>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.TaxRateId);
            Assert.AreEqual(result.Content.TaxBaseRate, item.TaxBaseRate);
        }

        /// <summary>
        /// Puts the tax rate should return status code.
        /// </summary>
        [TestMethod]
        public void PutTaxRate_ShouldReturnStatusCode()
        {
            var controller = new TaxRateController(new TestWidgitContext());

            var item = GetDemoTaxRate();

            var result = controller.Put(item.TaxRateId, item) as StatusCodeResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        /// <summary>
        /// Puts the tax rate should fail when different identifier.
        /// </summary>
        [TestMethod]
        public void PutTaxRate_ShouldFail_WhenDifferentID()
        {
            var controller = new TaxRateController(new TestWidgitContext());

            var badresult = controller.Put(999, GetDemoTaxRate());
            Assert.IsInstanceOfType(badresult, typeof(BadRequestResult));
        }
        /// <summary>
        /// Deletes the tax rate should return ok.
        /// </summary>
        [TestMethod]
        public void DeleteTaxRate_ShouldReturnOK()
        {
            var context = new TestWidgitContext();
            var item = GetDemoTaxRate();
            context.TaxRates.Add(item);

            var controller = new TaxRateController(context);
            var result = controller.Delete(1) as OkNegotiatedContentResult<TaxRate>;

            Assert.IsNotNull(result);
            Assert.AreEqual(item.TaxRateId, result.Content.TaxRateId);
        }

        /// <summary>
        /// Gets the demo tax rate.
        /// </summary>
        /// <returns>TaxRate.</returns>
        private TaxRate GetDemoTaxRate()
        {
            return new TaxRate { TaxRateId = 1, TaxBaseRate = 0.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") };
        }
    }
}
