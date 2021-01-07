﻿using Pds.Shared.Audit.Api.Services.Interfaces;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Services.Implementations
{
    /// <summary>
    /// Example service.
    /// </summary>
    public class ExampleService : IExampleService
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