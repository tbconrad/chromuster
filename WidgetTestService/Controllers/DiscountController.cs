// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="DiscountController.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Class StateController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class DiscountController : ApiController
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IWidgetContext _db = new WidgetContext();
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountController" /> class.
        /// </summary>
        public DiscountController() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountController" /> class.
        /// </summary>
        /// <param name="widgetContext">The widget context.</param>
        public DiscountController(IWidgetContext widgetContext)
        {
            _db = widgetContext;
        }

        /// <summary>
        /// Gets a collection of Discounts.
        /// </summary>
        /// <returns>IEnumerable&lt;State&gt;.</returns>
        [HttpGet]
        public IQueryable<Discount> Get()
        {
            return _db.Discounts;
        }

        /// <summary>
        /// Gets the Discount by specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>State.</returns>
        [HttpGet]
        [ResponseType(typeof(Discount))]
        public IHttpActionResult Get(int id)
        {
            Discount discount = _db.Discounts.FirstOrDefault(s => s.DiscountId == id);
            if (discount == null)
            {
                return NotFound();
            }
            return Ok(discount);
        }
        /// <summary>
        /// Puts the Discount by specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="discount">The discount.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Discount discount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != discount.DiscountId)
            {
                return BadRequest();
            }

            _db.MarkAsModified(discount);

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiscountExists(id))
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
        /// Posts the Discount.
        /// </summary>
        /// <param name="discount">The discount.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        [ResponseType(typeof(Discount))]
        public IHttpActionResult Post(Discount discount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Discounts.Add(discount);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = discount.DiscountId }, discount);
        }

        /// <summary>
        /// Deletes the Discount by specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        [ResponseType(typeof(Discount))]
        public IHttpActionResult Delete(int id)
        {
            Discount discount = _db.Discounts.Find(id);
            if (discount == null)
            {
                return NotFound();
            }

            _db.Discounts.Remove(discount);
            _db.SaveChanges();

            return Ok(discount);
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
        /// Checks if the Discount exists in the context.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool DiscountExists(int id)
        {
            return _db.Discounts.Count(e => e.DiscountId == id) > 0;
        }

    }
}
