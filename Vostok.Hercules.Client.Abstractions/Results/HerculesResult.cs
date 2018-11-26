using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesResult
    {
        public HerculesResult(HerculesStatus status)
        {
            Status = status;
        }

        public HerculesStatus Status { get; }

        public virtual bool IsSuccessful => Status == HerculesStatus.Success;

        public HerculesResult EnsureSuccess()
        {
            if (!IsSuccessful)
                throw new HerculesException(Status);

            return this;
        }

        public override string ToString()
        {
            return Status.ToString();
        }
    }
}
