// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="ValuesController.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace WidgetTestService.Controllers
{
    /// <summary>
    /// Class ValuesController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.String.</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Posts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
        }
    }
}
