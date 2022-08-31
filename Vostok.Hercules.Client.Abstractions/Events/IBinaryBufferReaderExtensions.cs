using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events;

[PublicAPI]
public static class IBinaryBufferReaderExtensions
{
    public static IDisposable JumpTo([NotNull] this IBinaryBufferReader reader, long position)
    {
        var originalPosition = reader.Position;

        reader.Position = position;

        return new JumpToken(reader, originalPosition);
    }

    internal struct JumpToken : IDisposable
    {
        private readonly long position;
        private readonly IBinaryBufferReader reader;

        public JumpToken(IBinaryBufferReader reader, long position)
        {
            this.reader = reader;
            this.position = position;
        }

        public void Dispose()
        {
            reader.Position = position;
        }
    }
}