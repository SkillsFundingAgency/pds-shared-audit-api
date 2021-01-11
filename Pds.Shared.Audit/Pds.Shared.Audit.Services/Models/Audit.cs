using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using DataModel = Pds.Shared.Audit.Repository.DataModels;
using DataModelInterfaces = Pds.Shared.Audit.Repository.Interfaces;

namespace Pds.Shared.Audit.Services.Models
{
    /// <summary>
    /// Audit item service model, that will be exposed as schema from API.
    /// </summary>
    public class Audit : DataModelInterfaces.IAudit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the severity.
        /// </summary>
        /// <value>
        /// The severity.
        /// </value>
        public int Severity { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [JsonIgnore]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the ukprn.
        /// </summary>
        /// <value>
        /// The ukprn.
        /// </value>
        public int? Ukprn { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>
        /// The action.
        /// </value>
        public int Action { get; set; }
    }
}
