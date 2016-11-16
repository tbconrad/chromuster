// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="WidgetController.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WidgetTest.Model;
using WidgetTest.Models;
using WidgetTest.Repository;

namespace WidgetTest.Controllers
{
    /// <summary>
    /// Class WidgetController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class WidgetController : Controller
    {
        /// <summary>
        /// The widget repository
        /// </summary>
        private readonly IWidgetRepository _widgetRepository;
        /// <summary>
        /// The state repository
        /// </summary>
        private readonly IStateRepository _stateRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetController"/> class.
        /// </summary>
        public WidgetController()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetController"/> class.
        /// </summary>
        /// <param name="widgetRepository">The widget repository.</param>
        /// <param name="stateRepository">The state repository.</param>
        public WidgetController(IWidgetRepository widgetRepository, IStateRepository stateRepository)
        {
           
            _widgetRepository = widgetRepository;
            _stateRepository = stateRepository;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            var widgets = _widgetRepository.GetAll().OrderBy(w => w.Name);
            var states = _stateRepository.GetAll().OrderBy(s => s.StateName);
            OrderWidgetViewModel model = new OrderWidgetViewModel
            {
                Widgets = widgets,
                States = states
            };

            return View(model);
        }

        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public ActionResult Order(OrderWidgetViewModel model)
        {
            ReloadModel(model);
            if (ModelState.IsValid)
            {
                CalculateTotal(model);
            }
            return View("Index", model);
        }

        /// <summary>
        /// Reloads the model.
        /// </summary>
        /// <param name="model">The model.</param>
        private void ReloadModel(OrderWidgetViewModel model)
        {
            model.Widgets = _widgetRepository.GetAll();
            model.States = _stateRepository.GetAll();

        }

        /// <summary>
        /// Gets the state tax rate.
        /// </summary>
        /// <param name="states">The states.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>System.Double.</returns>
        private double GetStateTaxRate(IEnumerable<State> states, int id )
        {
            if (states == null) return 0.00;
            var selectedState = states.FirstOrDefault(i => i.StateId == id);
            return selectedState?.TaxRate.TaxBaseRate ?? 0.00;
        }

        /// <summary>
        /// Gets the widget discount.
        /// </summary>
        /// <param name="widgets">The widgets.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>System.Double.</returns>
        private double GetWidgetDiscount(IEnumerable<Widget> widgets, int id)
        {
            if (widgets == null) return 0.00;
            var selectedWidget = widgets.FirstOrDefault(w => w.WidgetId == id && w.DiscountAvailable == true);
            return selectedWidget?.Discount.DiscountPercentage ?? 0.00;
        }

        /// <summary>
        /// Gets the widget base price.
        /// </summary>
        /// <param name="widgets">The widgets.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>System.Double.</returns>
        private double GetWidgetBasePrice(IEnumerable<Widget> widgets, int id)
        {
            if (widgets == null) return 0.00;
            var selectedWidget = widgets.FirstOrDefault(w => w.WidgetId == id);
            return selectedWidget?.BasePrice ?? 0.00;

        }
        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="model">The model.</param>
        private void CalculateTotal(OrderWidgetViewModel model)
        {
            double taxRate = GetStateTaxRate(model.States, model.StateId);
            double discountRate = GetWidgetDiscount(model.Widgets, model.WidgetId);
            double widgetBasePrice = GetWidgetBasePrice(model.Widgets, model.WidgetId);

            double widgetSubTotal = widgetBasePrice*model.Quantity;
            double discountTotal = widgetSubTotal*(discountRate/100);
            double widgetTotal = widgetSubTotal-discountTotal;
            double salesTax = Math.Abs(taxRate) <= 0 ? 0.00 : (widgetTotal * (taxRate / 100));
            double grandTotal = widgetTotal + salesTax;

            model.TaxRate = taxRate;
            model.DiscountTotal = discountTotal;
            model.WidgetBasePrice = widgetBasePrice;
            model.SalesTax = salesTax;
            model.Total = grandTotal;
            model.Success = true;
        }

        ///// <summary>
        ///// Releases unmanaged resources and optionally releases managed resources.
        ///// </summary>
        ///// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _widgetRepository.Dispose();
        //        _stateRepository.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}