// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="HomeController.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Web.Mvc;

namespace WidgetTestService.Controllers
{
    /// <summary>
    /// Class HomeController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
