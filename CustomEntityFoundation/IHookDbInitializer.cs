﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEntityFoundation
{
    /// <summary>
    /// Initialize data for modules
    /// </summary>
    public interface IHookDbInitializer
    {
        /// <summary>
        /// value smaller is higher priority
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Load data
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dc"></param>
        /// <returns></returns>
        void Load(IConfiguration config, EntityDbContext dc);
    }
}
