using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class SeekToEndStreamPayload
    {
        public SeekToEndStreamPayload(
            [NotNull] StreamCoordinates next)
        {
            Next = next ?? throw new ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Coordinates for the next sequential read. Put them in a <see cref="ReadStreamQuery"/> to continue reading from this point.
        /// </summary>
        [NotNull]
        public StreamCoordinates Next { get; }
    }
}