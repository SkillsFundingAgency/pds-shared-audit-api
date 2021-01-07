using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pds.Core.Logging;
using Pds.Shared.Audit.Api.Services.Interfaces;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Api.Controllers
{
    /// <summary>
    /// The example controller.
    /// </summary>
    [ApiController]
    public class ExampleController : BaseApiController
    {
        private readonly ILoggerAdapter<ExampleController> _logger;
        private readonly IExampleService _exampleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="exampleService">The example service.</param>
        public ExampleController(
            ILoggerAdapter<ExampleController> logger,
            IExampleService exampleService)
        {
            _logger = logger;
            _exampleService = exampleService;
        }

        /// <summary>
        /// Get the example page.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet]
        public async Task<string> Get()
        {
            _logger.LogInformation("The example page was requested.");
            return await _exampleService.Hello();
        }
    }
}