// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="WidgetControllerTest.cs" company="Conrad Enterprise, Inc.">
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
    /// Class WidgetControllerTest.
    /// </summary>
    [TestClass]
    public class WidgetControllerTest
    {
        /// <summary>
        /// Gets the widget should return widget with same identifier.
        /// </summary>
        [TestMethod]
        public void GetWidget_ShouldReturnWidgetWithSameId()
        {
            var context = new TestWidgitContext();
            context.Widgets.Add(GetDemoWidget());

            var controller = new WidgetController(context);
            var result = controller.Get(1) as OkNegotiatedContentResult<Widget>;

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Content.WidgetId);
        }

        /// <summary>
        /// Gets the widgets should return all widgets.
        /// </summary>
        [TestMethod]
        public void GetWidgets_ShouldReturnAllWidgets()
        {
            var context = new TestWidgitContext();
            context.Widgets.Add(new Widget { Name = "Fasecore-Widget", BasePrice = 34.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2, Discount = new Discount { DiscountId = 1, DiscountPercentage = 5, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") } });
            context.Widgets.Add(new Widget { Name = "Hothotit-Widget", BasePrice = 24.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2, Discount = new Discount { DiscountId = 1, DiscountPercentage = 5, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") } });
            context.Widgets.Add(new Widget { Name = "Indigo Hotstrong-Widget", BasePrice = 14.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2, Discount = new Discount { DiscountId = 1, DiscountPercentage = 5, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") } });


            var controller = new WidgetController(context);
            var result = controller.Get() as TestWidgetDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        /// <summary>
        /// Posts the widget should return same widget.
        /// </summary>
        [TestMethod]
        public void PostWidget_ShouldReturnSameWidget()
        {
            var controller = new WidgetController(new TestWidgitContext());

            var item = GetDemoWidget();

            var result =
                controller.Post(item) as CreatedAtRouteNegotiatedContentResult<Widget>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.WidgetId);
            Assert.AreEqual(result.Content.Discount, item.Discount);
        }

        /// <summary>
        /// Puts the widget should return status code.
        /// </summary>
        [TestMethod]
        public void PutWidget_ShouldReturnStatusCode()
        {
            var controller = new WidgetController(new TestWidgitContext());

            var item = GetDemoWidget();

            var result = controller.Put(item.WidgetId, item) as StatusCodeResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        /// <summary>
        /// Puts the widget should fail when different identifier.
        /// </summary>
        [TestMethod]
        public void PutWidget_ShouldFail_WhenDifferentID()
        {
            var controller = new WidgetController(new TestWidgitContext());

            var badresult = controller.Put(999, GetDemoWidget());
            Assert.IsInstanceOfType(badresult, typeof(BadRequestResult));
        }
        /// <summary>
        /// Deletes the widget should return ok.
        /// </summary>
        [TestMethod]
        public void DeleteWidget_ShouldReturnOK()
        {
            var context = new TestWidgitContext();
            var item = GetDemoWidget();
            context.Widgets.Add(item);

            var controller = new WidgetController(context);
            var result = controller.Delete(1) as OkNegotiatedContentResult<Widget>;

            Assert.IsNotNull(result);
            Assert.AreEqual(item.WidgetId, result.Content.WidgetId);
        }

        /// <summary>
        /// Gets the demo widget.
        /// </summary>
        /// <returns>Widget.</returns>
        private Widget GetDemoWidget()
        {
            return new Widget { WidgetId = 1, Name = "Fasecore-Widget", BasePrice = 34.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 };
        }
    }
}
