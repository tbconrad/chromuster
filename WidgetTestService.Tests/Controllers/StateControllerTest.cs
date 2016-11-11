// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="StateControllerTest.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgetTestService.Controllers;
using WidgetTestService.Models;

namespace WidgetTestService.Tests.Controllers
{
    /// <summary>
    /// Class TestStateController.
    /// </summary>
    [TestClass]
    public class StateControllerTest
    {
        /// <summary>
        /// Gets the state should return state with same identifier.
        /// </summary>
        [TestMethod]
        public void GetState_ShouldReturnStateWithSameId()
        {
            var context = new TestWidgitContext();
            context.States.Add(GetDemoStates());

            var controller = new StateController(context);
            var result = controller.Get(1) as OkNegotiatedContentResult<State>;

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Content.StateId);
        }

        /// <summary>
        /// Gets the states should return all states.
        /// </summary>
        [TestMethod]
        public void GetStates_ShouldReturnAllStates()
        {
            var context = new TestWidgitContext();
            context.States.Add(new State { StateId = 1, StateName = "Alabama", StateAbbreviation = "AL", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });
            context.States.Add(new State { StateId = 2, StateName = "Alaska", StateAbbreviation = "AK", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });
            context.States.Add(new State { StateId = 3, StateName = "Arizona", StateAbbreviation = "AZ", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") });

            var controller = new StateController(context);
            var result = controller.Get() as TestStateDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        /// <summary>
        /// Gets the demo states.
        /// </summary>
        /// <returns>State.</returns>
        private State GetDemoStates()
        {
            return new State { StateId = 1, StateName = "Alabama", StateAbbreviation = "AL", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") };
        }
    }
}
