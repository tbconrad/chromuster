// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="StateController.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using WidgetTestService.DAL;
using WidgetTestService.Models;

namespace WidgetTestService.Controllers
{
    /// <summary>
    /// Class StateController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class StateController : ApiController
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IWidgetContext _db = new WidgetContext();
        /// <summary>
        /// Initializes a new instance of the <see cref="StateController"/> class.
        /// </summary>
        public StateController() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateController"/> class.
        /// </summary>
        /// <param name="widgetContext">The widget context.</param>
        public StateController(IWidgetContext widgetContext)
        {
            _db = widgetContext;
        }

        /// <summary>
        /// Gets a collection of States.
        /// </summary>
        /// <returns>IEnumerable&lt;State&gt;.</returns>
        [HttpGet]
        public IQueryable<State> Get()
        {
            return _db.States.Include("TaxRate");
        }

        /// <summary>
        /// Gets the State by specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>State.</returns>
        [HttpGet]
        [ResponseType(typeof(State))]
        public IHttpActionResult Get(int id)
        {
            State state = _db.States.Include("TaxRate").FirstOrDefault(s => s.StateId == id);
            if (state == null)
            {
                return NotFound();
            }
            return Ok(state);
        }

        /// <summary>
        /// Releases the unmanaged resources that are used by the object and, optionally, releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
