using System;
using System.Collections;
using System.Threading;

namespace PubLish.Utils
{
    public class DateTimeOffsetProviderContext : IDisposable
    {
        internal readonly DateTimeOffset ContextDateTimeOffsetUtcNow;
        private static readonly AsyncLocal<Stack> ThreadScopeStack = new AsyncLocal<Stack>();

        public DateTimeOffsetProviderContext(DateTimeOffset contextDateTimeOffsetUtcNow)
        {
            ContextDateTimeOffsetUtcNow = contextDateTimeOffsetUtcNow;
            ThreadScopeStack.Value ??= new Stack();
            ThreadScopeStack.Value.Push(this);
        }

        public static DateTimeOffsetProviderContext? Current =>
            ThreadScopeStack.Value == null || ThreadScopeStack.Value.Count == 0
                ? null
                : ThreadScopeStack.Value.Peek() as DateTimeOffsetProviderContext;

        public void Dispose()
        {
            if (ThreadScopeStack.Value.Count > 0)
                ThreadScopeStack.Value.Pop();
        }
    }
}