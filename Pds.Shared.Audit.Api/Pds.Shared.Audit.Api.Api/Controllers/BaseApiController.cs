using Microsoft.AspNetCore.Mvc;

namespace Pds.Shared.Audit.Api.Api.Controllers
{
    /// <summary>
    /// Base class for an API controller.
    /// </summary>
    [Route("api/[controller]", Name = "[controller]_[action]")]
    public abstract class BaseApiController : ControllerBase
    {
    }
}