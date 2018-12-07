﻿using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class InsertEventsResult : HerculesResult
    {
        public InsertEventsResult(HerculesStatus status)
            : base(status)
        {
        }
    }
}