// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="DiscountControllerTest.cs" company="Conrad Enterprise, Inc.">
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
    /// Class DiscountControllerTest.
    /// </summary>
    [TestClass]
    public class DiscountControllerTest
    {
        /// <summary>
        /// Gets the discount should return discount with same identifier.
        /// </summary>
        [TestMethod]
        public void GetDiscount_ShouldReturnDiscountWithSameId()
        {
            var context = new TestWidgitContext();
            context.Discounts.Add(GetDemoDiscount());

            var controller = new DiscountController(context);
            var result = controller.Get(1) as OkNegotiatedContentResult<Discount>;

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Content.DiscountId);
        }

        /// <summary>
        /// Gets the discounts should return all discounts.
        /// </summary>
        [TestMethod]
        public void GetDiscounts_ShouldReturnAllDiscounts()
        {
            var context = new TestWidgitContext();
            context.Discounts.Add(new Discount { DiscountId = 1, DiscountPercentage = 5, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });
            context.Discounts.Add(new Discount { DiscountId = 2, DiscountPercentage = 10, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });
            context.Discounts.Add(new Discount { DiscountId = 3, DiscountPercentage = 15, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });

            var controller = new DiscountController(context);
            var result = controller.Get() as TestDiscountDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        /// <summary>
        /// Posts the discount should return same discount.
        /// </summary>
        [TestMethod]
        public void PostDiscount_ShouldReturnSameDiscount()
        {
            var controller = new DiscountController(new TestWidgitContext());

            var item = GetDemoDiscount();

            var result =
                controller.Post(item) as CreatedAtRouteNegotiatedContentResult<Discount>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.DiscountId);
            Assert.AreEqual(result.Content.DiscountPercentage, item.DiscountPercentage);
        }

        /// <summary>
        /// Puts the discount should return status code.
        /// </summary>
        [TestMethod]
        public void PutDiscount_ShouldReturnStatusCode()
        {
            var controller = new DiscountController(new TestWidgitContext());

            var item = GetDemoDiscount();

            var result = controller.Put(item.DiscountId, item) as StatusCodeResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        /// <summary>
        /// Puts the discount should fail when different identifier.
        /// </summary>
        [TestMethod]
        public void PutDiscount_ShouldFail_WhenDifferentID()
        {
            var controller = new DiscountController(new TestWidgitContext());

            var badresult = controller.Put(999, GetDemoDiscount());
            Assert.IsInstanceOfType(badresult, typeof(BadRequestResult));
        }
        /// <summary>
        /// Deletes the discount should return ok.
        /// </summary>
        [TestMethod]
        public void DeleteDiscount_ShouldReturnOK()
        {
            var context = new TestWidgitContext();
            var item = GetDemoDiscount();
            context.Discounts.Add(item);

            var controller = new DiscountController(context);
            var result = controller.Delete(1) as OkNegotiatedContentResult<Discount>;

            Assert.IsNotNull(result);
            Assert.AreEqual(item.DiscountId, result.Content.DiscountId);
        }

        /// <summary>
        /// Gets the demo discount.
        /// </summary>
        /// <returns>Discount.</returns>
        private Discount GetDemoDiscount()
        {
            return new Discount { DiscountId = 1, DiscountPercentage = 5, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") };

        }
    }
}
