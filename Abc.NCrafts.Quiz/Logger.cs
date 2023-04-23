using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Abc.NCrafts.Quiz
{
    public static class Logger
    {
        public static bool Enabled { get; set; }

        public static void Log<T>(T value)
        {
            if (Enabled)
                Console.WriteLine(value?.ToString());
        }

        public static void Log(ReadOnlySpan<char> text)
        {
            if (Enabled)
                Console.WriteLine(text.ToString());
        }

        public static void Log(ref LoggerInterpolatedStringHandler handler)
        {
            handler.Log();
        }
        
        [InterpolatedStringHandler]
        public readonly ref struct LoggerInterpolatedStringHandler
        {
            private readonly StringBuilder _stringBuilder;

            public LoggerInterpolatedStringHandler(int literalLength, int formattedCount, out bool isHandlerValid)
            {
                var enabled = Enabled;
                isHandlerValid = enabled;
                _stringBuilder = enabled ? new StringBuilder(literalLength + formattedCount * 4) : null;
            }

            public void AppendLiteral(string value)
                => _stringBuilder.Append(value);

            public void AppendFormatted<T>(T value)
                => _stringBuilder.Append(value);

            public void Log()
            {
                if (_stringBuilder != null)
                    Console.WriteLine(_stringBuilder.ToString());
            }
        }
    }
}
