using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace SpyStore.DAL
{
    public class MyConnectionStrategy : MyExecutionStrategy
    {
        public MyConnectionStrategy(DbContext context) : base(context)
        {
        }

        public MyConnectionStrategy(DbContext context, int maxRetryCount, TimeSpan maxRetryDelay) : base(context, maxRetryCount, maxRetryDelay)
        {
        }

        public MyConnectionStrategy(ExecutionStrategyDependencies dependencies) : base(dependencies)
        {
        }

        public MyConnectionStrategy(ExecutionStrategyDependencies dependencies, int maxRetryCount, TimeSpan maxRetryDelay) : base(dependencies, maxRetryCount, maxRetryDelay)
        {
        }
    }
}
