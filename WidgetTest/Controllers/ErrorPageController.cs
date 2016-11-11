// ***********************************************************************
// Assembly         : WidgetTest
// Author           : Tim Conrad
// Created          : 11-10-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-10-2016
// ***********************************************************************
// <copyright file="ErrorPageController.cs" company="Conrad Enterprise, Inc.">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Web.Mvc;

namespace WidgetTest.Controllers
{
    /// <summary>
    /// Class ErrorPageController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        /// <summary>
        /// Errors the message.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult ErrorMessage()
        {
            return View();
        }
    }
}