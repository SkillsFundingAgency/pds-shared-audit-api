using System.Threading.Tasks;

namespace Pds.Shared.Audit.Repository.Interfaces
{
    /// <summary>
    /// Unit of work helps to manage transactions across more than one data sets.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits this instance asynchronously.
        /// </summary>
        /// <returns>Async task.</returns>
        Task CommitAsync();
    }
}