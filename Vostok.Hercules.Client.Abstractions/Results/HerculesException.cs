using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesException : Exception
    {
        public HerculesException(string message)
            : base(message)
        {
        }

        public HerculesException(HerculesStatus status, string details = null)
            : this($"Hercules operation has failed with status '{status}'. {details}")
        {
        }
    }
}