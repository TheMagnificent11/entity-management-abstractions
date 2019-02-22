﻿using System;

namespace EntityManagement.Core
{
    /// <summary>
    /// Base Enum Entity
    /// </summary>
    /// <typeparam name="TKey">Enum entity key type</typeparam>
    public abstract class BaseEnumEntity<TKey> : IEnumEntity<TKey>
        where TKey : struct, IConvertible, IComparable
    {
        /// <summary>
        /// Gets or sets the ID of the enum entity
        /// </summary>
        public TKey Id { get; protected set; }

        /// <summary>
        /// Gets or sets the name of the enum entity
        /// </summary>
        public string Name { get; protected set; }
    }
}
