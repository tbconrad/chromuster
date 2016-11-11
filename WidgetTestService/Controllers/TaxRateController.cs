// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="TaxRateController.cs" company="Conrad Enterprise, Inc.">
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
    /// Class StateController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TaxRateController : ApiController
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IWidgetContext _db = new WidgetContext();
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateController" /> class.
        /// </summary>
        public TaxRateController() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateController" /> class.
        /// </summary>
        /// <param name="widgetContext">The widget context.</param>
        public TaxRateController(IWidgetContext widgetContext)
        {
            _db = widgetContext;
        }

        /// <summary>
        /// Gets a collection of TaxRates.
        /// </summary>
        /// <returns>IEnumerable&lt;State&gt;.</returns>
        [HttpGet]
        public IQueryable<TaxRate> Get()
        {
            return _db.TaxRates;
        }

        /// <summary>
        /// Gets the TaxRate by specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>State.</returns>
        [HttpGet]
        [ResponseType(typeof(TaxRate))]
        public IHttpActionResult Get(int id)
        {
            TaxRate taxRate = _db.TaxRates.FirstOrDefault(s => s.TaxRateId == id);
            if (taxRate == null)
            {
                return NotFound();
            }
            return Ok(taxRate);
        }

        /// <summary>
        /// Puts the TaxRate ny the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="taxRate">The tax rate.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, TaxRate taxRate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taxRate.TaxRateId)
            {
                return BadRequest();
            }

            _db.MarkAsModified(taxRate);

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaxRateExists(id))
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
        /// Posts the TaxRate.
        /// </summary>
        /// <param name="taxRate">The tax rate.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        [ResponseType(typeof(TaxRate))]
        public IHttpActionResult Post(TaxRate taxRate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.TaxRates.Add(taxRate);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = taxRate.TaxRateId }, taxRate);
        }

        /// <summary>
        /// Deletes the specified TaxRate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        [ResponseType(typeof(TaxRate))]
        public IHttpActionResult Delete(int id)
        {
            TaxRate taxRate = _db.TaxRates.Find(id);
            if (taxRate == null)
            {
                return NotFound();
            }

            _db.TaxRates.Remove(taxRate);
            _db.SaveChanges();

            return Ok(taxRate);
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
        /// Checks if the TaxRate exists in the context.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool TaxRateExists(int id)
        {
            return _db.TaxRates.Count(e => e.TaxRateId == id) > 0;
        }

    }
}
