// ***********************************************************************
// Assembly         : WidgetTest.Tests
// Author           : Tim Conrad
// Created          : 11-09-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-09-2016
// ***********************************************************************
// <copyright file="WidgetControllerTest.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WidgetTest.Controllers;
using WidgetTest.Model;
using WidgetTest.Models;
using WidgetTest.Repository;

namespace WidgetTest.Tests.Controllers
{
    /// <summary>
    /// Class WidgetControllerTest.
    /// </summary>
    [TestClass]
    public class WidgetControllerTest
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        [TestMethod]
        public void Index()
        {
            Mock<IWidgetRepository> mockWidgetRepository = new Mock<IWidgetRepository>();
            Mock<IStateRepository> mockStateRepository = new Mock<IStateRepository>();
            mockWidgetRepository.Setup(e => e.GetAll()).Returns(GetWidgetCollection().AsQueryable());
            mockStateRepository.Setup(e => e.GetAll()).Returns(GetStateCollection().AsQueryable());
            var controller = new WidgetController(mockWidgetRepository.Object, mockStateRepository.Object);

            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);

        }

        /// <summary>
        /// Does the repositories fetch the right number.
        /// </summary>
        [TestMethod]
        public void DoRepositoriesFetchTheRightNumber()
        {
            Mock<IWidgetRepository> mockWidgetRepository = new Mock<IWidgetRepository>();
            Mock<IStateRepository> mockStateRepository = new Mock<IStateRepository>();
            mockWidgetRepository.Setup(e => e.GetAll()).Returns(GetWidgetCollection().AsQueryable());
            mockStateRepository.Setup(e => e.GetAll()).Returns(GetStateCollection().AsQueryable());
            var controller = new WidgetController(mockWidgetRepository.Object, mockStateRepository.Object);

            var result = controller.Index() as ViewResult;
            var model = result.Model as OrderWidgetViewModel;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, model.Widgets.Count());
            Assert.AreEqual(3, model.States.Count());
        }

        /// <summary>
        /// Checks the calculation.
        /// </summary>
        [TestMethod]
        public void CheckCalculation()
        {
            Mock<IWidgetRepository> mockWidgetRepository = new Mock<IWidgetRepository>();
            Mock<IStateRepository> mockStateRepository = new Mock<IStateRepository>();
            mockWidgetRepository.Setup(e => e.GetAll()).Returns(GetWidgetCollection().AsQueryable());
            mockStateRepository.Setup(e => e.GetAll()).Returns(GetStateCollection().AsQueryable());
            var controller = new WidgetController(mockWidgetRepository.Object, mockStateRepository.Object);

            var result = controller.Index() as ViewResult;
            var model = result.Model as OrderWidgetViewModel;
            model.WidgetId = 1;
            model.StateId = 1;
            model.Quantity = 1;

            result = controller.Order(model) as ViewResult;

            Assert.IsNotNull(result);
            var val = Math.Round(model.WidgetBasePrice, 2);
            Assert.AreEqual(3.50, Math.Round(model.DiscountTotal, 2));
            Assert.AreEqual(1.57, Math.Round(model.SalesTax, 2));
            Assert.AreEqual(33.03, Math.Round(model.Total, 2));
            Assert.AreEqual(34.95, Math.Round(model.WidgetBasePrice, 2));
        }

        /// <summary>
        /// Gets the widget collection.
        /// </summary>
        /// <returns>IEnumerable&lt;Widget&gt;.</returns>
        private IEnumerable<Widget> GetWidgetCollection()
        {
            var collection = new List<Widget>
            {
                new Widget() { WidgetId = 1, Name = "Fasecore-Widget", BasePrice = 34.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2, Discount = new Discount() { DiscountId = 2, DiscountPercentage = 10, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }},
                new Widget() { WidgetId = 2, Name = "Hothotit-Widget", BasePrice = 24.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2, Discount = new Discount() { DiscountId = 2, DiscountPercentage = 10, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }},
                new Widget() { WidgetId = 3, Name = "Indigo Hotstrong-Widget", BasePrice = 14.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2, Discount = new Discount() { DiscountId = 2, DiscountPercentage = 10, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }},
            };

            return collection;
        }

        /// <summary>
        /// Gets the state collection.
        /// </summary>
        /// <returns>IEnumerable&lt;State&gt;.</returns>
        private IEnumerable<State> GetStateCollection()
        {
            var collection = new List<State>
            {
                new State() { StateId = 1, StateName = "Alabama", StateAbbreviation = "AL", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), TaxRate = new TaxRate() { TaxRateId = 18, TaxBaseRate = 5.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }},
                new State() { StateId = 2, StateName = "Alaska", StateAbbreviation = "AK", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), TaxRate = new TaxRate() { TaxRateId = 18, TaxBaseRate = 5.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }},
                new State() { StateId = 3, StateName = "Arizona", StateAbbreviation = "AZ", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), TaxRate = new TaxRate() { TaxRateId = 18, TaxBaseRate = 5.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }}
            };
            return collection;
        }
    }
}
