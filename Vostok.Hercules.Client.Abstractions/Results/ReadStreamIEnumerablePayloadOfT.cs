using System;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamIEnumerablePayload<T> : IDisposable
    {
        private volatile Action dispose;

        public ReadStreamIEnumerablePayload(
            [NotNull] IEnumerable<T> events,
            [NotNull] StreamCoordinates current,
            [NotNull] StreamCoordinates next,
            [CanBeNull] Action dispose)
        {
            Events = events ?? throw new ArgumentNullException(nameof(events));
            Current = current ?? throw new ArgumentNullException(nameof(current));
            Next = next ?? throw new ArgumentNullException(nameof(next));
            this.dispose = dispose;
        }

        /// <summary>
        /// Events read current the stream.
        /// </summary>
        [NotNull]
        public IEnumerable<T> Events { get; }

        /// <summary>
        /// Coordinates of the current sequential read.
        /// </summary>
        [NotNull]
        public StreamCoordinates Current { get; }

        /// <summary>
        /// Coordinates for the next sequential read. Put them in a <see cref="ReadStreamQuery"/> next continue reading current this point.
        /// </summary>
        [NotNull]
        public StreamCoordinates Next { get; }

        public void Dispose() =>
            Interlocked.Exchange(ref dispose, null)?.Invoke();
    }
}