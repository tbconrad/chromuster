// ***********************************************************************
// Assembly         : WidgetTestService
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

using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WidgetTestService.DAL;
using WidgetTestService.Models;

namespace WidgetTestService.Controllers
{
    /// <summary>
    /// Class WidgetController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class WidgetController : ApiController
    {
        /// <summary>
        /// The database context
        /// </summary>
        private readonly IWidgetContext _db = new WidgetContext();
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetController"/> class.
        /// </summary>
        public WidgetController() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetController"/> class.
        /// </summary>
        /// <param name="widgetContext">The widget context.</param>
        public WidgetController(IWidgetContext widgetContext)
        {
            _db = widgetContext;
        }

        /// <summary>
        /// Gets all Widgets and their associated Discounts.
        /// </summary>
        /// <returns>IQueryable&lt;Widget&gt;.</returns>
        [HttpGet]
        public IQueryable<Widget> Get()
        {
            return _db.Widgets.Include("Discount").OrderBy(n => n.Name);
        }

        /// <summary>
        /// Gets the Widget by the specified identifier including it's associated Discount.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        [ResponseType(typeof(Widget))]
        public IHttpActionResult Get(int id)
        {
            Widget widget = _db.Widgets.Include("Discount").FirstOrDefault(s => s.WidgetId == id);
            if (widget == null)
            {
                return NotFound();
            }
            return Ok(widget);
        }

        /// <summary>
        /// Puts the Widget by the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="widget">The widget.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        [ResponseType(typeof(void))]
        //TODO: This only will save the Widget not the associated Discount.
        public IHttpActionResult Put(int id, Widget widget)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != widget.WidgetId)
            {
                return BadRequest();
            }

            _db.MarkAsModified(widget);

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WidgetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Posts the specified widget.
        /// </summary>
        /// <param name="widget">The widget.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        [ResponseType(typeof(Widget))]
        public IHttpActionResult Post(Widget widget)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Widgets.Add(widget);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = widget.WidgetId }, widget);
        }

        /// <summary>
        /// Deletes the Widget by the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        [ResponseType(typeof(Widget))]
        public IHttpActionResult Delete(int id)
        {
            Widget widget = _db.Widgets.Find(id);
            if (widget == null)
            {
                return NotFound();
            }

            _db.Widgets.Remove(widget);
            _db.SaveChanges();

            return Ok(widget);
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

        /// <summary>
        /// Checks to see it the Widget already exists in the context.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool WidgetExists(int id)
        {
            return _db.Widgets.Count(e => e.WidgetId == id) > 0;
        }

    }
}
