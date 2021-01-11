using Microsoft.AspNetCore.Mvc;
using Pds.Core.Logging;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Controllers
{
    /// <summary>
    /// The example controller.
    /// </summary>
    public class AuditController : BaseApiController
    {
        private readonly ILoggerAdapter<AuditController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public AuditController(
            ILoggerAdapter<AuditController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Basic get method.
        /// </summary>
        /// <returns>returns ok.</returns>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return await Ok("Hello");
        }
    }
}