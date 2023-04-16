using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Abc.NCrafts.Quiz
{
    public static class Logger
    {
        public static bool Enabled { get; set; }

        [Conditional("DEBUG")]
        public static void Log<T>(T value)
        {
            if (Enabled)
                Console.WriteLine(value?.ToString());
        }

        [Conditional("DEBUG")]
        public static void LogAscii(byte[] bytes, long length)
        {
            if (Enabled)
                Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, (int)length));
        }
        
        [Conditional("DEBUG")]
        public static void Log(ReadOnlySpan<char> text)
        {
            if (Enabled)
                Console.WriteLine(text.ToString());
        }

        [Conditional("DEBUG")]
        public static void Log(ref LoggerInterpolatedStringHandler handler)
        {
            if (Enabled)
                Console.WriteLine(handler.ToString());
        }
        
        [InterpolatedStringHandler]
        public readonly ref struct LoggerInterpolatedStringHandler
        {
            private readonly StringBuilder _stringBuilder;

            public LoggerInterpolatedStringHandler(int literalLength, int formattedCount)
            {
                _stringBuilder = Enabled ? new StringBuilder(literalLength + formattedCount * 4) : null;
            }

            public void AppendLiteral(string value)
                => _stringBuilder?.Append(value);

            public void AppendFormatted(ReadOnlySpan<char> value)
                => _stringBuilder?.Append(value);

            public void AppendFormatted(string value)
                => _stringBuilder?.Append(value);

            public void AppendFormatted<T>(T value)
                => _stringBuilder?.Append(value);

            public override string ToString()
                => _stringBuilder.ToString();
        }
    }
}
