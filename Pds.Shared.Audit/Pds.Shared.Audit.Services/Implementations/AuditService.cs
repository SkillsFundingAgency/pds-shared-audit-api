using Pds.Shared.Audit.Services.Interfaces;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Services.Implementations
{
    /// <summary>
    /// Audit service.
    /// </summary>
    public class AuditService : IAuditService
    {
        /// <summary>
        /// Hello.
        /// </summary>
        /// <returns>The hello string.</returns>
        public async Task<string> Hello()
        {
            return await Task.FromResult("Hello, world!");
        }
    }
}