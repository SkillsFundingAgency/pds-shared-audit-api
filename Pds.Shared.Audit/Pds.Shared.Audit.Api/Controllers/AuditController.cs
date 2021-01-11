using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pds.Core.Logging;
using Pds.Shared.Audit.Services.Interfaces;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Controllers
{
    /// <summary>
    /// The audit controller.
    /// </summary>
    public class AuditController : BaseApiController
    {
        private readonly ILoggerAdapter<AuditController> _logger;
        private readonly IAuditService _auditService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="auditService">The audit service.</param>
        public AuditController(
            ILoggerAdapter<AuditController> logger,
            IAuditService auditService)
        {
            _logger = logger;
            _auditService = auditService;
        }


        /// <summary>
        /// Basic get method.
        /// </summary>
        /// <returns>returns ok.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _auditService.Hello());
        }
    }
}