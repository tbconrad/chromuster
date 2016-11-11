// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="OrderController.cs" company="Conrad Enterprise, Inc.">
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
    /// Class OrderController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class OrderController : ApiController
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IWidgetContext _db = new WidgetContext();
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderController" /> class.
        /// </summary>
        public OrderController() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderController" /> class.
        /// </summary>
        /// <param name="widgetContext">The widget context.</param>
        public OrderController(IWidgetContext widgetContext)
        {
            _db = widgetContext;
        }

        /// <summary>
        /// Gets all Orders including widgets and States.
        /// </summary>
        /// <returns>IQueryable&lt;Order&gt;.</returns>
        [HttpGet]
        public IQueryable<Order> Get()
        {
            return _db.Orders.Include("Widget").Include("State");
        }

        /// <summary>
        /// Gets the Orders including widgets and States for the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        [ResponseType(typeof(Order))]
        public IHttpActionResult Get(int id)
        {
            Order order = _db.Orders.Include("Widget").Include("State").FirstOrDefault(s => s.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        /// <summary>
        /// Puts the specified Order by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="order">The order.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderId)
            {
                return BadRequest();
            }

            _db.MarkAsModified(order);

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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
        /// Posts the specified Order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        [ResponseType(typeof(Order))]
        public IHttpActionResult Post(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Orders.Add(order);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order.OrderId }, order);
        }

        /// <summary>
        /// Deletes the specified Order by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        [ResponseType(typeof(Order))]
        public IHttpActionResult Delete(int id)
        {
            Order order = _db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            _db.Orders.Remove(order);
            _db.SaveChanges();

            return Ok(order);
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
        /// Checks if the Order exists in the context.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool OrderExists(int id)
        {
            return _db.Orders.Count(e => e.OrderId == id) > 0;
        }

    }
}
