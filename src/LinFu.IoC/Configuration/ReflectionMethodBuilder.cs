﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinFu.IoC.Configuration.Interfaces;
using System.Reflection;

namespace LinFu.IoC.Configuration
{
    /// <summary>
    /// Represents a <see cref="IMethodBuilder{TMethod}"/> type that simply lets 
    /// methods pass through it without performing any modifications to those methods.
    /// </summary>
    public class ReflectionMethodBuilder<TMethod> : IMethodBuilder<TMethod>
        where TMethod : MethodBase
    {
        /// <summary>
        /// Returns the <paramref name="existingMethod"/> unmodified.
        /// </summary>
        /// <param name="existingMethod">The method to be modified.</param>
        /// <returns>The modified method.</returns>
        public MethodBase CreateMethod(TMethod existingMethod)
        {
            return existingMethod;
        }
    }
}
