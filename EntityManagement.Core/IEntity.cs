﻿using System;

namespace EntityManagement.Core
{
    /// <summary>
    /// Entity Interface
    /// </summary>
    /// <typeparam name="TId">ID type</typeparam>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Gets the ID of the entity
        /// </summary>
        TId Id { get; }

        /// <summary>
        /// Gets the username of the user that created the entity
        /// </summary>
        string CreatedBy { get; }

        /// <summary>
        /// Gets the date-time in UTC at which the entity was created
        /// </summary>
        DateTime CreatedAtUtc { get; }

        /// <summary>
        /// Gets the username of the user that last modified the entity
        /// </summary>
        string ModifiedBy { get; }

        /// <summary>
        /// Gets the date-time in UTC at which the entity was last updated
        /// </summary>
        DateTime ModifiedAtUtc { get; }
    }
}
