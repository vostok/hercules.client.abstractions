using System.Text;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    internal static class HerculesTagsRenderer
    {
        private const string NullRepresentation = "<null>";
        private const string OpeningSquareBracket = "[";
        private const string OpeningCurlyBracket = "{";
        private const string ClosingSquareBracket = "]";
        private const string ClosingCurlyBracket = "}";

        private const char Quote = '"';
        private const char Comma = ',';
        private const char Colon = ':';
        private const char Space = ' ';

        public static string Render([NotNull] HerculesTags tags, int startingDepth = 0)
        {
            var builder = new StringBuilder();

            Render(tags, builder, startingDepth);

            return builder.ToString();
        }

        public static string Render([NotNull] HerculesVector vector, int startingDepth = 0)
        {
            var builder = new StringBuilder();

            Render(vector, builder, startingDepth);

            return builder.ToString();
        }

        private static void Render([NotNull] HerculesTags tags, [NotNull] StringBuilder builder, int depth)
        {
            if (tags.Count == 0)
            {
                builder
                    .Indent(depth)
                    .Append(OpeningCurlyBracket)
                    .Append(ClosingCurlyBracket);

                return;
            }

            builder
                .Indent(depth)
                .AppendLine(OpeningCurlyBracket);

            var counter = 0;

            foreach (var pair in tags)
            {
                builder
                    .Indent(depth + 1)
                    .Append(Quote)
                    .Append(pair.Key)
                    .Append(Quote)
                    .Append(Colon)
                    .Append(Space);

                if (HasChildren(pair.Value))
                {
                    builder.AppendLine();
                    Render(pair.Value, builder, depth + 1);
                }
                else
                {
                    Render(pair.Value, builder, 0);
                }

                if (++counter < tags.Count)
                    builder.Append(Comma);

                builder.AppendLine();
            }

            builder
                .Indent(depth)
                .Append(ClosingCurlyBracket);
        }

        private static void Render([NotNull] HerculesVector vector, [NotNull] StringBuilder builder, int depth)
        {
            if (vector.Count == 0)
            {
                builder
                    .Indent(depth)
                    .Append(OpeningSquareBracket)
                    .Append(ClosingSquareBracket);

                return;
            }

            builder
                .Indent(depth)
                .AppendLine(OpeningSquareBracket);

            var counter = 0;

            foreach (var element in vector.Elements)
            {
                Render(element, builder, depth + 1);

                if (++counter < vector.Count)
                    builder.Append(Comma);

                builder.AppendLine();
            }

            builder
                .Indent(depth)
                .Append(ClosingSquareBracket);
        }

        private static void Render([CanBeNull] HerculesValue value, [NotNull] StringBuilder builder, int depth)
        {
            if (value == null || value.IsNull)
            {
                builder.Indent(depth).Append(NullRepresentation);
            }
            else if (value.IsContainer)
            {
                Render(value.AsContainer, builder, depth);
            }
            else if (value.IsVector)
            {
                Render(value.AsVector, builder, depth);
            }
            else
            {
                builder.Indent(depth).Append(value);
            }
        }

        private static bool HasChildren([CanBeNull] HerculesValue value)
        {
            if (value == null)
                return false;

            if (value.IsContainer && value.AsContainer.Count > 0)
                return true;

            if (value.IsVector && value.AsVector.Count > 0)
                return true;

            return false;
        }

        private static StringBuilder Indent([NotNull] this StringBuilder builder, int depth)
            => builder.Append(Space, depth * 3);
    }
}