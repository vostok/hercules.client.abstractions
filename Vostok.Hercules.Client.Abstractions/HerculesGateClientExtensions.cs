namespace Vostok.Hercules.Client.Abstractions
{
    public static class HerculesGateClientExtensions
    {
        public static void Put(this IHerculesGateClient client, string stream, HerculesRecord record) =>
            client.Put(stream, builder => builder.SetTimestamp(record.Timestamp).Add(record.Tags));
    }
}