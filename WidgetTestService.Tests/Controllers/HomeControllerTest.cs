// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="HomeControllerTest.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgetTestService.Controllers;

namespace WidgetTestService.Tests.Controllers
{
    /// <summary>
    /// Class HomeControllerTest.
    /// </summary>
    [TestClass]
    public class HomeControllerTest
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
