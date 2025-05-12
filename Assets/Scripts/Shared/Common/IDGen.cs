using System.Threading;

namespace Shared.Common
{
    public class IDGen
    {
        private static long _tempId = 1;

        public static long GetNewId() => Interlocked.Increment(ref _tempId);
    }
}