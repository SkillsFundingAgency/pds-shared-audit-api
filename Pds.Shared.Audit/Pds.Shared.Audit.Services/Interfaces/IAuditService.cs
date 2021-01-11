using System.Threading.Tasks;

namespace Pds.Shared.Audit.Services.Interfaces
{
    /// <summary>
    /// Audit service.
    /// </summary>
    public interface IAuditService
    {
        /// <summary>
        /// Hello.
        /// </summary>
        /// <returns>The hello string.</returns>
        Task<string> Hello();
    }
}