// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="OrderWidgetViewModel.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WidgetTest.Models;

namespace WidgetTest.Model
{
    /// <summary>
    /// Class OrderWidgetViewModel.
    /// </summary>
    public class OrderWidgetViewModel
    {
        /// <summary>
        /// Gets or sets the selected state identifier.
        /// </summary>
        /// <value>The state identifier.</value>
        [DisplayName("Selected StateId")]
        [Required(ErrorMessage = "Please select a State.")]
        public int StateId { get; set; }
        /// <summary>
        /// Gets or sets the selected widget identifier.
        /// </summary>
        /// <value>The widget identifier.</value>
        [DisplayName("Selected WidgetId")]
        [Required(ErrorMessage = "Please select a Widget.")]
        public int WidgetId { get; set; }
        /// <summary>
        /// Gets or sets the quantity of widgets that were requested.
        /// </summary>
        /// <value>The quantity.</value>
        [Required(ErrorMessage = "Please indicate quantity.")]
        [Range(1,10000, ErrorMessage = "You must order at least 1 item")]
        [DisplayName("Quantity:")]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the states collection.
        /// </summary>
        /// <value>The states.</value>
        [DisplayName("State:")]
        public IEnumerable<State> States { get; set; }
        /// <summary>
        /// Gets or sets the widgets collection.
        /// </summary>
        /// <value>The widgets.</value>
        [DisplayName("Widgets")]
        public IEnumerable<Widget> Widgets { get; set; }

        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        /// <value>The tax rate.</value>
        [DisplayName("State Tax Rate:")]
        public double TaxRate { get; set; }
        /// <summary>
        /// Gets or sets the discount rate.
        /// </summary>
        /// <value>The discount rate.</value>
        [DisplayName("Discount Total:")]
        public double DiscountTotal { get; set; }
        /// <summary>
        /// Gets or sets the widget base price.
        /// </summary>
        /// <value>The widget base price.</value>
        [DisplayName("Widget(s) Price:")]
        public double WidgetBasePrice { get; set; }
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [DisplayName("Grand Total:")]
        public double Total { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="OrderWidgetViewModel"/> is calculated.
        /// </summary>
        /// <value><c>true</c> if calculated; otherwise, <c>false</c>.</value>
        public bool Calculated { get; set; } = false;
        /// <summary>
        /// Gets or sets the sales tax.
        /// </summary>
        /// <value>The sales tax.</value>
        [DisplayName("Sales Tax:")]
        public double SalesTax { get; set; }
    }
}