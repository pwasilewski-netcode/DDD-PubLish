using System;

namespace PubLish.Utils
{
    public static class DateTimeOffsetProvider
    {
        public static DateTimeOffset UtcNow =>
            DateTimeOffsetProviderContext.Current == null
                ? DateTimeOffset.UtcNow
                : DateTimeOffsetProviderContext.Current.ContextDateTimeOffsetUtcNow;
    }
}